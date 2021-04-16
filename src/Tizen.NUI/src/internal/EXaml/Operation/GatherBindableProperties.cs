﻿/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Binding.Internals;

namespace Tizen.NUI.EXaml
{
    internal class GatherBindableProperties : Operation
    {
        public GatherBindableProperties(int typeIndex, string propertyName)
        {
            this.typeIndex = typeIndex;
            this.propertyName = propertyName;
        }

        public void Do()
        {
            var type = GatherType.GatheredTypes[typeIndex];
            var field = type.GetField(fi => fi.Name == propertyName && fi.IsStatic && fi.IsPublic);
            if (null == field)
            {
                field = type.GetField(fi => fi.Name == propertyName && fi.IsStatic && !fi.IsPublic);
            }

            GatheredBindableProperties.Add(field.GetValue(null) as BindableProperty);
        }

        private int typeIndex;
        private string propertyName;
        internal static List<BindableProperty> GatheredBindableProperties = new List<BindableProperty>();
    }
}
