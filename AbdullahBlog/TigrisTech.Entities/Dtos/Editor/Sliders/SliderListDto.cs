﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Shared.Entities.Abstract;



namespace TigrisTech.Entities.Dtos.Editor.Sliders
{
    public class SliderListDto : DtoGetBase
    {
        public IList<Slider> Sliders { get; set; }
    }
}