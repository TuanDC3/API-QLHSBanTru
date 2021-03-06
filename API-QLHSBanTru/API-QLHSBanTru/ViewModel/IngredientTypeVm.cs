﻿using System.Collections.Generic;

namespace API_QLHSBanTru.ViewModel
{
    public class IngredientTypeVm
    {
        public int IngredientTypeID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<IngredientVm> Ingredients { get; set; }
    }
}