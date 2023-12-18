using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;

namespace Sistema_Prestamos.src.services
{
    public class CobradorService
    {
        private readonly PrestamoContext _context;

        public CobradorService(PrestamoContext context)
        {
            _context = context;
        }

        public List<Cobrador> GetAllCobradores()
        {
            var cobradores = _context.Cobrador.ToList();

            return cobradores.Select(cobrador => new Cobrador
            {
                Id = cobrador.Id,
                Nombre = cobrador.Nombre,
                Cedula = cobrador.Cedula,
                Telefono = cobrador.Telefono,
                Zonas = cobrador.Zonas,
                Provincia = cobrador.Provincia,
                Localidad = cobrador.Localidad,
                Direcion = cobrador.Direcion,
                CreatedAt = cobrador.CreatedAt,
                UpdatedAt = cobrador.UpdatedAt
            }).ToList();
        }



        public Cobrador GetCobrador(int id)
        {
            try
            {
                var cobrador = _context.Cobrador.Find(id);

                if (cobrador != null)
                {
                    return cobrador;
                }
                else
                {
                    throw new NotFoundException($"No se encontró el cobrador con ID {id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el cobrador con ID {id}: {ex.Message}");
                throw;
            }
        }

        public void AddCobrador(string name, string cedula, string telefono, Zona zona, string provincia, string localidad, Direccion direccion)  // Modificado
        {
            try
            {
                Cobrador newCobrador = new Cobrador
                {
                    Nombre = name,
                    Cedula = cedula,
                    Telefono = telefono,
                    Zonas = zona.Nombre,  // Modificado
                    Provincia = provincia,
                    Localidad = localidad,
                    Direcion = direccion.Nombre,  // Modificado
                    CreatedAt = DateTime.Now
                };

                _context.Cobrador.Add(newCobrador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar un nuevo cobrador: {ex.Message}");
            }
        }

        public void UpdateCobrador(int cobradorId, string newName, string newCedula, string newTelefono, Zona newZona, string newProvincia, string newLocalidad, Direccion newDireccion)  // Modificado
        {
            try
            {
                Cobrador existingCobrador = _context.Cobrador.Find(cobradorId)!;

                if (existingCobrador != null)
                {
                    existingCobrador.Nombre = newName;
                    existingCobrador.Cedula = newCedula;
                    existingCobrador.Telefono = newTelefono;
                    existingCobrador.Zonas = newZona.Nombre;  // Modificado
                    existingCobrador.Provincia = newProvincia;
                    existingCobrador.Localidad = newLocalidad;
                    existingCobrador.Direcion = newDireccion.Nombre;  // Modificado
                    existingCobrador.UpdatedAt = DateTime.Now;

                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el cobrador con ID {cobradorId} para actualizar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el cobrador con ID {cobradorId}: {ex.Message}");
            }
        }

        public void DeleteCobrador(int cobradorId)
        {
            try
            {
                var cobradorToDelete = _context.Cobrador.Find(cobradorId);

                if (cobradorToDelete != null)
                {
                    _context.Cobrador.Remove(cobradorToDelete);
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el cobrador con ID {cobradorId} para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el cobrador con ID {cobradorId}: {ex.Message}");
            }
        }

        public bool IsCedulaAlreadyExists(string cedula, int idExcluir = 0)
        {
            return _context.Set<Cobrador>()
                .Any(c => c.Id != idExcluir && c.Cedula == cedula);
        }
    }
}
