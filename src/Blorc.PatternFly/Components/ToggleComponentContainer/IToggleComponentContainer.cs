﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IToggleComponentContainer.cs" company="WildGums">
//   Copyright (c) 2008 - 2019 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Blorc.PatternFly.Components.ToggleComponentContainer
{
    using System;

    using Blorc.PatternFly.Core;

    public interface IToggleComponentContainer
    {
        event EventHandler<ToggleComponentChangedEventArg> ToogleComponentChanged;

        void Register(IToggleComponent toggleComponent);
    }
}
