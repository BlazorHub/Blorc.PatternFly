﻿namespace Blorc.PatternFly.Components.Card
{
    using Blorc.Components;
    using Blorc.StateConverters;
    using Microsoft.AspNetCore.Components;

    public class CardHeaderComponent : BlorcComponentBase
    {
        public CardHeaderComponent()
        {
            Component = "div";

            CreateConverter()
                .Fixed("pf-c-card__header")
                .Fixed("pf-c-title")
                .Fixed("pf-m-lg")
                .Update(() => Class);
        }

        public string Class { get; set; }

        [Parameter]
        public string Component { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
