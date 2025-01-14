﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class LoxodonFrameworkContextsApplicationContextWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Loxodon.Framework.Contexts.ApplicationContext);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMainLoopExcutor", _m_GetMainLoopExcutor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGlobalPreferences", _m_GetGlobalPreferences);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUserPreferences", _m_GetUserPreferences);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new Loxodon.Framework.Contexts.ApplicationContext();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<Loxodon.Framework.Services.IServiceContainer>(L, 2) && translator.Assignable<Loxodon.Framework.Execution.IMainLoopExecutor>(L, 3))
				{
					Loxodon.Framework.Services.IServiceContainer _container = (Loxodon.Framework.Services.IServiceContainer)translator.GetObject(L, 2, typeof(Loxodon.Framework.Services.IServiceContainer));
					Loxodon.Framework.Execution.IMainLoopExecutor _mainLoopExecutor = (Loxodon.Framework.Execution.IMainLoopExecutor)translator.GetObject(L, 3, typeof(Loxodon.Framework.Execution.IMainLoopExecutor));
					
					var gen_ret = new Loxodon.Framework.Contexts.ApplicationContext(_container, _mainLoopExecutor);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Loxodon.Framework.Contexts.ApplicationContext constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMainLoopExcutor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Loxodon.Framework.Contexts.ApplicationContext gen_to_be_invoked = (Loxodon.Framework.Contexts.ApplicationContext)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetMainLoopExcutor(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalPreferences(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Loxodon.Framework.Contexts.ApplicationContext gen_to_be_invoked = (Loxodon.Framework.Contexts.ApplicationContext)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetGlobalPreferences(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUserPreferences(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Loxodon.Framework.Contexts.ApplicationContext gen_to_be_invoked = (Loxodon.Framework.Contexts.ApplicationContext)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetUserPreferences( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
