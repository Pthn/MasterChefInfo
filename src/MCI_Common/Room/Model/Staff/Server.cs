﻿using Room.Model.Client;
using MCI_Common.Recipes;
using MCI_Common.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room.Model.Staff
{
    public class Server : Staff
    {
        /// <summary>
        /// Square in the room
        /// </summary>
        //private Square mySquare;

        /// <summary>
        /// Sprite of the rank chief
        /// </summary>
        private string Sprite;

        /// <summary>
        /// Serve the client's meal
        /// </summary>
        /// <param name="clients"></param>
        public void ServeMeal(ClientGroup clts, Order order)
        {
            //Gets meals on ready counter

            //Gives the meals

            if(clts.MealProgression == RecipeType.UNKNOWN)
                clts.MealProgression = RecipeType.STARTER;
            else if (clts.MealProgression == RecipeType.STARTER)
                clts.MealProgression = RecipeType.MAIN;
            else if (clts.MealProgression == RecipeType.MAIN)
                clts.MealProgression = RecipeType.DESSERT;
            else if (clts.MealProgression == RecipeType.DESSERT)
                clts.MealProgression = RecipeType.FINISHED;
        }

        /// <summary>
        /// Clean the client's meal
        /// </summary>
        /// <param name="clients"></param>
        public void ClearMeal(ClientGroup clients)
        {
            Console.WriteLine("Clearing meal of group {0}", clients.Id);

            foreach (Client.Client clt in clients.ClientList)
                clt.Served = false;

            if (clients.MealProgression == RecipeType.MAIN)
                clients.OrderDessert();                
            
        }

        /// <summary>
        /// Add something on a table
        /// </summary>
        /// <param name="table"></param>
        /* public void AddOnTable(Table table)
        {
            
        }
        */

        public override void WhoAmI()
        {
            Console.WriteLine("I'm a Server");
        }
    }
}
