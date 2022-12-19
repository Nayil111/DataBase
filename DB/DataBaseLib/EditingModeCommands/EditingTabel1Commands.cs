using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingTabel1Commands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Ученики] ([ФИО],[Класс],[ID Классух],[ID Тариф]) VALUES ('{args[0]}','{args[1]}',{args[2]}, {args[3]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args, int number)
        {
            string query = $"UPDATE [Ученики] SET [Класс] = ('{args[0]}'), [ID Классух] = ('{args[1]}'), [ID Тариф] = ('{args[2]}') WHERE [Номер ученика] = " + number;
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Ученики] WHERE [Номер ученика] = " + number;
            controller.ExecuteCommand(query);
        }
    }
}
