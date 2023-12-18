using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;

namespace Sistema_Prestamos.src.services
{
    public class DireccionService
    {
        private PrestamoContext _context;

        public DireccionService(PrestamoContext context)
        {
            _context = context;
        }

        public List<Direccion> GetAllDirecciones()
        {
            var direcciones = _context.Direccion.ToList();

            return direcciones;
        }

        public Direccion GetDireccion(int id)
        {
            try
            {
                return _context.Direccion.Find(id) ?? throw new NotFoundException($"No se encontró la dirección con ID {id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la dirección con ID {id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
        }

        public void AddDireccion(string name)
        {
            try
            {
                Direccion newDireccion = new Direccion { Nombre = name, CreatedAt = DateTime.Now };

                _context.Direccion.Add(newDireccion);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar una nueva dirección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDireccion(int direccionId, string newName)
        {
            try
            {
                Direccion existingDireccion = _context.Direccion.Find(direccionId) ?? throw new NotFoundException($"No se encontró la dirección con ID {direccionId}");

                existingDireccion.Nombre = newName;
                existingDireccion.UpdatedAt = DateTime.Now;

                _context.SaveChanges();

                MessageBox.Show($"Dirección con ID:{existingDireccion.Id} Actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la dirección con ID {direccionId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteDireccion(int direccionId)
        {
            try
            {
                var direccionToDelete = _context.Direccion.Find(direccionId) ?? throw new NotFoundException($"No se encontró la dirección con ID {direccionId}");

                _context.Direccion.Remove(direccionToDelete);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la dirección con ID {direccionId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsNombreAlreadyExists(string nombre, int idExcluir = 0)
        {
            return _context.Set<Direccion>()
                .Any(d => d.Id != idExcluir && d.Nombre == nombre);
        }
    }
}
