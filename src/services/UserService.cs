using OpenQA.Selenium;
using Sistema_Prestamos.src.data.sqlserver;
using Sistema_Prestamos.src.data.sqlserver.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Prestamos.src.services
{
    public class UserService
    {
        private PrestamoContext _context;

        public UserService(PrestamoContext context)
        {
            _context = context;
        }

        public List<object> GetAllUser()
        {
            var users = _context.Usuarios.ToList();

            return users.Select(user => new
            {
                user.Id,
                user.Name,
                user.Email,
                user.Level_acces,
                user.CreatedAt,
                user.UpdatedAt
            }).Cast<object>().ToList();
        }

        public Usuario GetUser(int Id)
        {
            try
            {
                return _context.Usuarios.Find(Id)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el usuario con ID {Id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
        }

        public void AddUser(string name, string email, string password, string acces)
        {
            try
            {
                Usuario newUser = Usuario.crate(name, email, password, acces);

                _context.Usuarios.Add(newUser);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes registrar el error, mostrar un mensaje, lanzar una excepción personalizada, etc.)
                MessageBox.Show($"Error al agregar un nuevo usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes propagar la excepción si prefieres que la gestión se realice en un nivel superior
                // throw;
            }
        }

        public void UpdateUser(int userId, string newName, string newEmail, string newPassword, string newAccessLevel)
        {
            try
            {
                // Obtén el usuario existente desde la base de datos
                Usuario existingUser = _context.Usuarios.Find(userId)!;

                if (existingUser != null)
                {
                    // Actualiza las propiedades del usuario con los nuevos valores
                    existingUser.Name = newName;
                    existingUser.Email = newEmail;
                    existingUser.Password = newPassword;
                    existingUser.Level_acces = newAccessLevel;
                    existingUser.UpdatedAt = DateTime.Now;

                    // Guarda los cambios en la base de datos
                    _context.SaveChanges();

                    MessageBox.Show($"Usuario con ID:{existingUser.Id} Actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Manejo si el usuario no se encuentra
                    MessageBox.Show($"No se encontró el usuario con ID {userId} para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes registrar el error, mostrar un mensaje, etc.)
                MessageBox.Show($"Error al actualizar el usuario con ID {userId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                // Busca el usuario a eliminar
                var userToDelete = _context.Usuarios.Find(userId);

                if (userToDelete != null)
                {
                    // Elimina el usuario
                    _context.Usuarios.Remove(userToDelete);
                    _context.SaveChanges();

                    // Puedes agregar lógica adicional después de eliminar el usuario si es necesario
                }
                else
                {
                    // Si el usuario no se encuentra, puedes lanzar una excepción o manejarlo de otra manera
                    throw new NotFoundException($"No se encontró el usuario con ID {userId}");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (puedes registrar el error, mostrar un mensaje, etc.)
                MessageBox.Show($"Error al eliminar el usuario con ID {userId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
