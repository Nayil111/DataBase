using DataBaseLib.Access;
using DataBaseLib.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.EditingModeCommands
{
    internal class EditingTeachersCommands : ItabelEditingCommands
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [Преподователя] ([Код преподователя],[ФИО],[Руководит классом]) VALUES ('{args[0]}','{args[1]}',{args[2]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args, int number)
        {
            string query = $"UPDATE [Преподователя] SET [Руководит классом] = ('{args[0]}') WHERE [Код преподователя] = " + number;
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args,int number)
        {
            string query = $"DELETE FROM [Преподователя] WHERE [Код преподователя] = " + number;
            controller.ExecuteCommand(query);
        }
    }
}
