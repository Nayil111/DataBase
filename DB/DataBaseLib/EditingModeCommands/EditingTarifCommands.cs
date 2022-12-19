using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingTarifCommands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Расписание] ([Код дня],[Класс],[Преподаватель]) VALUES ('{args[0]}','{args[1]}',{args[2]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args, int number)
        {
            string query = $"UPDATE [Тарифы] SET [Вид тарифа] = ('{args[0]}'), [Стоимость тарифа] = ('{args[1]}') WHERE [Код тарифа] = " + number;
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args, int number)
        {
            string query = $"DELETE FROM [Тарифы] WHERE [Код тарифа] = " + number;
            controller.ExecuteCommand(query);
        }
    }
}
