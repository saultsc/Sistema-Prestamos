using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;

namespace Sistema_Prestamos.src.services
{
    public class ClienteService
    {
        private readonly PrestamoContext _context;

        public ClienteService(PrestamoContext context)
        {
            _context = context;
        }

        public List<Cliente> GetAllClientes()
        {
            var clientes = _context.Cliente.ToList();

            return clientes.Select(cliente => new Cliente
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Cedula = cliente.Cedula,
                Telefono = cliente.Telefono,

                Zonas = cliente.Zonas,
                Agente = cliente.Agente,
                Cobrador = cliente.Cobrador,

                Direcion = cliente.Direcion,

                Balance = cliente.Balance,
                CreatedAt = cliente.CreatedAt,
                UpdatedAt = cliente.UpdatedAt
            }).ToList();
        }

        public List<object> AllDataGridClientes()
        {
            var clientes = _context.Cliente.ToList();

            return clientes.Select(cliente => new
            {
                cliente.Id,
                cliente.Nombre,
                cliente.Cedula,
                cliente.Telefono,
                cliente.Zonas,
                cliente.Agente,
                cliente.Cobrador,
                cliente.Direcion,
                cliente.Balance,
                cliente.CreatedAt,
                cliente.UpdatedAt
            }).Cast<object>().ToList();
        }

        public Cliente GetCliente(int id)
        {
            try
            {
                var cliente = _context.Cliente.Find(id);

                if (cliente != null)
                {
                    return cliente;
                }
                else
                {
                    throw new NotFoundException($"No se encontró el cliente con ID {id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el cliente con ID {id}: {ex.Message}");
                throw;
            }
        }

        public void AddCliente(string name, string cedula, string telefono, string representante, Zona zona, Agente agente, Cobrador cobrador, string provincia, string localidad, Direccion direccion, string trabajo)
        {
            try
            {
                Cliente newCliente = new Cliente
                {
                    Nombre = name,
                    Cedula = cedula,
                    Telefono = telefono,
                    Representante = representante,
                    Zonas = zona.Nombre,  // Ahora se asigna directamente el objeto Zona
                    Agente = agente.Nombre,  // Igualmente, se asigna el objeto Agente
                    Cobrador = cobrador.Nombre,  // Y el objeto Cobrador
                    Provincia = provincia,
                    Localidad = localidad,
                    Direcion = direccion.Nombre,  // Y el objeto Direccion
                    Trabajo = trabajo,
                    CreatedAt = DateTime.Now
                };

                _context.Cliente.Add(newCliente);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar un nuevo cliente: {ex.Message}");
            }
        }

        public void UpdateCliente(int clienteId, string newName, string newCedula, string newTelefono, string newRepresentante, Zona newZona, Agente newAgente, Cobrador newCobrador, string newProvincia, string newLocalidad, Direccion newDireccion, string newTrabajo, double newBalance)
        {
            try
            {
                Cliente existingCliente = _context.Cliente.Find(clienteId)!;

                if (existingCliente != null)
                {
                    existingCliente.Nombre = newName;
                    existingCliente.Cedula = newCedula;
                    existingCliente.Telefono = newTelefono;
                    existingCliente.Representante = newRepresentante;
                    existingCliente.Zonas = newZona.Nombre;  // Asignación directa del nuevo objeto Zona
                    existingCliente.Agente = newAgente.Nombre;  // Asignación del nuevo objeto Agente
                    existingCliente.Cobrador = newCobrador.Nombre;  // Asignación del nuevo objeto Cobrador
                    existingCliente.Provincia = newProvincia;
                    existingCliente.Localidad = newLocalidad;
                    existingCliente.Direcion = newDireccion.Nombre;  // Asignación del nuevo objeto Direccion
                    existingCliente.Trabajo = newTrabajo;
                    existingCliente.Balance = newBalance;
                    existingCliente.UpdatedAt = DateTime.Now;

                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el cliente con ID {clienteId} para actualizar.");
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Error al actualizar el cliente con ID {clienteId}: {ex.Message}");
                // Puedes agregar más lógica de manejo de errores según sea necesario.
            }
        }

        public void DeleteCliente(int clienteId)
        {
            try
            {
                var clienteToDelete = _context.Cliente.Find(clienteId);

                if (clienteToDelete != null)
                {
                    _context.Cliente.Remove(clienteToDelete);
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"No se encontró el cliente con ID {clienteId} para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el cliente con ID {clienteId}: {ex.Message}");
            }
        }

        public bool IsCedulaAlreadyExists(string cedula, int idExcluir = 0)
        {
            return _context.Set<Cliente>()
                .Any(c => c.Id != idExcluir && c.Cedula == cedula);
        }
    }
}
