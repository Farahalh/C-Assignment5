using C_Assignment5.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment5.UI
{
        public class UIManager
        {
            private GarageHandler garageHandler;

            public UIManager(GarageHandler garageHandler)
            {
                this.garageHandler = garageHandler;
            }

            public void Start()
            {
                // Implement the main user interface loop here
                // Display menus, capture user input, and call methods in garageHandler
            }

            // Implement methods for displaying menus and handling user input
        }
    }
