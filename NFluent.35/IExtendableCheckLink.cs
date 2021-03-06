﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IExtendableCheckLink.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    /// <summary>
    /// Provides an specific implementation for IEnumerable fluent check extension. Required to implement IEnumerable fluent API syntax.
    /// </summary>
    /// <typeparam name="T">
    /// Type managed by this extension.
    /// </typeparam>
    public interface IExtendableCheckLink<out T> : ICheckLink<ICheck<T>>
    {
        /// <summary>
        /// Gets the initial list that was used in Contains.
        /// </summary>
        /// <value>
        /// Initial list that was used in Contains.
        /// </value>
        T OriginalComparand { get; }
    }

    /// <summary>
    /// Provides an specific implementation for IEnumerable fluent check extension. Required to implement IEnumerable fluent API syntax.
    /// </summary>
    /// <typeparam name="T">Type managed by this extension.</typeparam>
    /// <typeparam name="U">Type of the reference comparand.</typeparam>
    public interface IExtendableCheckLink<out T, out U> : ICheckLink<ICheck<T>>
    {
        /// <summary>
        /// Gets the initial list that was used in Contains.
        /// </summary>
        /// <value>
        /// Initial list that was used in Contains.
        /// </value>
        U OriginalComparand { get; }
    }
}