﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCI_Common.RoomMaterials
{
    public abstract class RoomMaterial
    {
        /// <summary>
        /// Id of the material
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the material
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Qunatity available for this material
        /// </summary>
        public int Quantity { get; set; }
    }
}
