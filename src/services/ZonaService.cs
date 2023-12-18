using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;
using Sistema_Prestamos.src.views.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Prestamos.src.services
{
    public class ZonaService
    {
        private PrestamoContext _context;

        public ZonaService(PrestamoContext context)
        {
            _context = context;
        }

        public List<object> GetAllZonas()
        {
            var zonas = _context.Zona.ToList();

            return zonas.Select(zona => new
            {
                zona.Id,
                zona.Nombre,
                zona.CreatedAt,
                zona.UpdatedAt
            }).Cast<object>().ToList();
        }

        public Zona GetZona(int id)
        {
            try
            {
                return _context.Zona.Find(id)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la zona con ID {id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
        }

        public void AddZona(string name)
        {
            try
            {
                Zona newZona = new Zona { Nombre = name, CreatedAt = DateTime.Now};

                _context.Zona.Add(newZona);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar una nueva zona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateZona(int zonaId, string newName)
        {
            try
            {
                Zona existingZona = _context.Zona.Find(zonaId)!;

                if (existingZona != null)
                {
                    existingZona.Nombre = newName;
                    existingZona.UpdatedAt = DateTime.Now;

                    _context.SaveChanges();

                    MessageBox.Show($"Zona con ID:{existingZona.Id} Actualizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontró la zona con ID {zonaId} para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la zona con ID {zonaId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteZona(int zonaId)
        {
            try
            {
                var zonaToDelete = _context.Zona.Find(zonaId);

                if (zonaToDelete != null)
                {
                    _context.Zona.Remove(zonaToDelete);
                    _context.SaveChanges();
                }
                else
                {
                    throw new NotFoundException($"No se encontró la zona con ID {zonaId}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la zona con ID {zonaId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsNombreAlreadyExists(string nombre, int idExcluir = 0)
        {
            // Si idExcluir es proporcionado, excluimos el registro con ese ID de la verificación
            return _context.Set<Zona>()
                .Any(z => z.Id != idExcluir && z.Nombre == nombre);
        }
    }
}
