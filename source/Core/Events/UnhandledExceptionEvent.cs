﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Thinktecture.IdentityServer.Core.Events
{
    /// <summary>
    /// Event class for unhandled exceptions
    /// </summary>
    public class UnhandledExceptionEvent : EventBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledExceptionEvent"/> class.
        /// </summary>
        public UnhandledExceptionEvent() : base(EventConstants.Categories.InternalError)
        {
            EventType = Events.EventType.Error;
            Id = EventConstants.Ids.UnhandledException;
            Message = "Unhandled exception.";
        }
    }
}