using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsoulSharp;
using Troll.Event;
using Troll.Menu;

namespace Troll.Core
{
    public class Troll
    {
        public static void OnLoad()
        {
            MenuManager.LoadMenu();
            EventManager.LoadEvents();
        }
    }
}
