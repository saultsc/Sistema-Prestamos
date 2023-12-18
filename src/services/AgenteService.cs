using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;

namespace Sistema_Prestamos.src.services
{
    public class AgenteService
    {
        private readonly PrestamoContext _context;

        public AgenteService(PrestamoContext context)
        {
            _context = context;
        }

        public List<Agente> GetAllAgentes()
        {
            var agentes = _context.Agente.ToList();

            return agentes;
        }

        public Agente GetAgente(int id)
        {
            try
            {
                var agente = _context.Agente.Find(id);

                if (agente != null)
                {
                    return agente;
                }
                else
                {
                    // Puedes lanzar una excepción personalizada para indicar que no se encontró el agente con el ID especificado.
                    throw new NotFoundException($"No se encontró el agente con ID {id}");
                }
            }
            catch (Exception ex)
            {
                // Puedes lograr la excepción o lanzarla dependiendo de tus requisitos.
                Console.WriteLine($"Error al obtener el agente con ID {id}: {ex.Message}");
                throw; // Lanza la excepción original para mantener la información de la excepción.
            }
        }


        public void AddAgente(string nombre, string telefono, string cedula, string provincia, object zona)
        {
            try
            {
                // Desestructura el objeto zona para obtener su propiedad Nombre
                var zonaNombre = (string)zona.GetType().GetProperty("Nombre")?.GetValue(zona, null)!;

                Agente newAgente = new Agente
                {
                    Nombre = nombre,
                    Telefono = telefono,
                    Cedula = cedula,
                    Provincia = provincia,
                    Zona = zonaNombre,  // Asignar la propiedad Nombre de zona a Zona
                    CreatedAt = DateTime.Now
                };

                _context.Agente.Add(newAgente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar un nuevo agente: {ex.Message}");
                // Puedes manejar la excepción según tus requisitos, por ejemplo, mostrar un mensaje de error.
            }
        }



        public void UpdateAgente(int agenteId, string nuevoNombre, string nuevoTelefono, string nuevaCedula, string nuevaProvincia, object nuevaZona)
        {
            try
            {
                Agente existingAgente = _context.Agente.Find(agenteId)!;

                if (existingAgente != null)
                {
                    // Desestructura el objeto nuevaZona para obtener su propiedad Nombre
                    var zonaNombre = (string)nuevaZona.GetType().GetProperty("Nombre")?.GetValue(nuevaZona, null)!;

                    existingAgente.Nombre = nuevoNombre;
                    existingAgente.Telefono = nuevoTelefono;
                    existingAgente.Cedula = nuevaCedula;
                    existingAgente.Provincia = nuevaProvincia;
                    existingAgente.Zona = zonaNombre;
                    existingAgente.UpdatedAt = DateTime.Now;

                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el agente con ID {agenteId} para actualizar.");
                    // Puedes manejar la falta de agente según tus requisitos, por ejemplo, mostrar un mensaje de error.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el agente con ID {agenteId}: {ex.Message}");
                // Puedes manejar la excepción según tus requisitos, por ejemplo, mostrar un mensaje de error.
            }
        }


        public void DeleteAgente(int agenteId)
        {
            try
            {
                var agenteToDelete = _context.Agente.Find(agenteId);

                if (agenteToDelete != null)
                {
                    _context.Agente.Remove(agenteToDelete);
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el agente con ID {agenteId} para eliminar.");
                    // Puedes manejar la falta de agente según tus requisitos, por ejemplo, mostrar un mensaje de error.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el agente con ID {agenteId}: {ex.Message}");
                // Puedes manejar la excepción según tus requisitos, por ejemplo, mostrar un mensaje de error.
            }
        }

        public bool IsCedulaAlreadyExists(string cedula, int idExcluir = 0)
        {
            return _context.Set<Agente>()
                .Any(a => a.Id != idExcluir && a.Cedula == cedula);
        }

    }
}
