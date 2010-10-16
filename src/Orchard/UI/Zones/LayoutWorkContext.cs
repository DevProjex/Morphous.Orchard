﻿using System;
using ClaySharp.Implementation;
using Orchard.DisplayManagement;

namespace Orchard.UI.Zones {
    public class LayoutWorkContext : IWorkContextStateProvider {
        private readonly IShapeFactory _shapeFactory;

        public LayoutWorkContext(IShapeFactory shapeFactory) {
            _shapeFactory = shapeFactory;
        }

        public Func<T> Get<T>(string name) {
            if (name == "Layout") {
                var layout = _shapeFactory.Create("Layout", Arguments.Empty());
                return () => (T)layout;
            }
            return null;
        }
    }
}
