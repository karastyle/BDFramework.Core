﻿/*
 * MIT License
 *
 * Copyright (c) 2018 Clark Yang
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in 
 * the Software without restriction, including without limitation the rights to 
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
 * of the Software, and to permit persons to whom the Software is furnished to do so, 
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE 
 * SOFTWARE.
 */

using Loxodon.Framework.Binding.Contexts;

using XLua;

namespace Loxodon.Framework.Binding.Builder
{
    [LuaCallCSharp]
    public class LuaBindingSet : BindingSetBase
    {
        private object target;
        public LuaBindingSet(IBindingContext context, object target) : base(context)
        {
            this.target = target;
        }

        public virtual LuaBindingBuilder Bind()
        {
            var builder = new LuaBindingBuilder(this.context, this.target);
            this.builders.Add(builder);
            return builder;
        }

        public virtual LuaBindingBuilder Bind(object target)
        {
            var builder = new LuaBindingBuilder(context, target);
            this.builders.Add(builder);
            return builder;
        }
    }
}