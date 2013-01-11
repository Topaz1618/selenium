// <copyright file="ILocatable.cs" company="WebDriver Committers">
// Copyright 2007-2011 WebDriver committers
// Copyright 2007-2011 Google Inc.
// Portions copyright 2011 Software Freedom Conservancy
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenQA.Selenium.Interactions.Internal;

namespace OpenQA.Selenium
{
    /// <summary>
    /// Defines the interface through which the user can discover where an element is on the screen.
    /// </summary>
    public interface ILocatable
    {
        /// <summary>
        /// Gets the location of an element on the screen, scrolling it into view
        /// if it is not currently on the screen.
        /// </summary>
        Point LocationOnScreenOnceScrolledIntoView { get; }

        /// <summary>
        /// Gets the coordinates identifying the location of this element using
        /// various frames of reference.
        /// </summary>
        ICoordinates Coordinates { get; }
    }
}
