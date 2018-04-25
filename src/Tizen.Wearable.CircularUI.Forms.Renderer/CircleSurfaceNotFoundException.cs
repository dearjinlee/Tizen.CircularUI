﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.Serialization;

namespace Tizen.Wearable.CircularUI.Forms.Renderer
{
    [Serializable]
    public class CircleSurfaceNotFoundException : Exception
    {
        public CircleSurfaceNotFoundException()
        {
        }

        public CircleSurfaceNotFoundException(string message) : base(message)
        {
        }

        public CircleSurfaceNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CircleSurfaceNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}