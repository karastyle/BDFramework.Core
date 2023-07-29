﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.LuaBehaviour), XLuaTestLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.BaseTest), XLuaTestBaseTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Parent), XLuaTestFoo1ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Parent), XLuaTestFoo2ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Child), XLuaTestFoo1ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Child), XLuaTestFoo2ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo), XLuaTestFooWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.FooExtension), XLuaTestFooExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.UnityObjectExtensions), LoxodonFrameworkUnityObjectExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.LuaBehaviour), LoxodonFrameworkViewsLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.LuaUIView), LoxodonFrameworkViewsLuaUIViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.LuaView), LoxodonFrameworkViewsLuaViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.LuaWindow), LoxodonFrameworkViewsLuaWindowWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.Animations.GenericUIAnimation), LoxodonFrameworkViewsAnimationsGenericUIAnimationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.Animations.LuaUIAnimation), LoxodonFrameworkViewsAnimationsLuaUIAnimationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Binding.Lua.LuaBehaviourBindingExtension), LoxodonFrameworkBindingLuaLuaBehaviourBindingExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Binding.Lua.LuaGameObjectBindingExtension), LoxodonFrameworkBindingLuaLuaGameObjectBindingExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Binding.Builder.LuaBindingBuilder), LoxodonFrameworkBindingBuilderLuaBindingBuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Binding.Builder.LuaBindingSet), LoxodonFrameworkBindingBuilderLuaBindingSetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLua.LuaEntryBehaviour), XLuaLuaEntryBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Execution.Executors), LoxodonFrameworkExecutionExecutorsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Contexts.Context), LoxodonFrameworkContextsContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Contexts.ApplicationContext), LoxodonFrameworkContextsApplicationContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Contexts.PlayerContext), LoxodonFrameworkContextsPlayerContextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Prefs.Preferences), LoxodonFrameworkPrefsPreferencesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Localizations.ILocalization), LoxodonFrameworkLocalizationsILocalizationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Localizations.Localization), LoxodonFrameworkLocalizationsLocalizationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Messaging.Messenger), LoxodonFrameworkMessagingMessengerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Commands.SimpleCommand), LoxodonFrameworkCommandsSimpleCommandWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Asynchronous.AsyncResult), LoxodonFrameworkAsynchronousAsyncResultWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Asynchronous.AsyncResult<Loxodon.Framework.ViewModels.IViewModel>), LoxodonFrameworkAsynchronousAsyncResult_1_LoxodonFrameworkViewModelsIViewModel_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Observables.ObservableDictionary<object, object>), LoxodonFrameworkObservablesObservableDictionary_2_SystemObjectSystemObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Observables.ObservableList<object>), LoxodonFrameworkObservablesObservableList_1_SystemObject_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Specialized.NotifyCollectionChangedEventArgs), SystemCollectionsSpecializedNotifyCollectionChangedEventArgsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.ITransition), LoxodonFrameworkViewsITransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.WindowContainer), LoxodonFrameworkViewsWindowContainerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Asynchronous.ProgressResult<float, Loxodon.Framework.Views.IWindow>), LoxodonFrameworkAsynchronousProgressResult_2_SystemSingleLoxodonFrameworkViewsIWindow_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Asynchronous.ProgressResult<float, Loxodon.Framework.Views.IView>), LoxodonFrameworkAsynchronousProgressResult_2_SystemSingleLoxodonFrameworkViewsIView_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.IView), LoxodonFrameworkViewsIViewWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.IWindow), LoxodonFrameworkViewsIWindowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.Window), LoxodonFrameworkViewsWindowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.IWindowManager), LoxodonFrameworkViewsIWindowManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.WindowManager), LoxodonFrameworkViewsWindowManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.IUIViewLocator), LoxodonFrameworkViewsIUIViewLocatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Views.DefaultUIViewLocator), LoxodonFrameworkViewsDefaultUIViewLocatorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Type), SystemTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions), LoxodonFrameworkAsynchronousCoroutineAwaiterExtensionsWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Binding.Proxy.Sources.Object.ILuaObservableObject), LoxodonFrameworkBindingProxySourcesObjectILuaObservableObjectBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Asynchronous.ILuaTask), LoxodonFrameworkAsynchronousILuaTaskBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.InvokeLua.ICalc), XLuaTestInvokeLuaICalcBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.ViewModels.IViewModel), LoxodonFrameworkViewModelsIViewModelBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Asynchronous.IAwaiter), LoxodonFrameworkAsynchronousIAwaiterBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Asynchronous.IAwaiter<object>), LoxodonFrameworkAsynchronousIAwaiter_1_SystemObject_Bridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Asynchronous.IAwaiter<int>), LoxodonFrameworkAsynchronousIAwaiter_1_SystemInt32_Bridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Loxodon.Framework.Asynchronous.ILuaTask<int>), LoxodonFrameworkAsynchronousILuaTask_1_SystemInt32_Bridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate bool __GEN_DELEGATE0( UnityEngine.Object o);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE1( System.Collections.IEnumerator coroutine);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE2( UnityEngine.YieldInstruction instruction);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE3( Loxodon.Framework.Asynchronous.WaitForMainThread instruction);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE4( Loxodon.Framework.Asynchronous.WaitForBackgroundThread instruction);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter<UnityEngine.CustomYieldInstruction> __GEN_DELEGATE5( UnityEngine.CustomYieldInstruction instruction);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE6( UnityEngine.AsyncOperation target);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter<UnityEngine.Object> __GEN_DELEGATE7( UnityEngine.ResourceRequest target);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter<UnityEngine.Object> __GEN_DELEGATE8( UnityEngine.AssetBundleRequest target);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter<UnityEngine.AssetBundle> __GEN_DELEGATE9( UnityEngine.AssetBundleCreateRequest target);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter<UnityEngine.Networking.UnityWebRequest> __GEN_DELEGATE10( UnityEngine.Networking.UnityWebRequestAsyncOperation target);
		
		delegate Loxodon.Framework.Asynchronous.IAwaiter __GEN_DELEGATE11( Loxodon.Framework.Asynchronous.IAsyncResult target);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityEngine.Object), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(Loxodon.Framework.UnityObjectExtensions.IsDestroyed)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.Collections.IEnumerator), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE1(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.YieldInstruction), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE2(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(Loxodon.Framework.Asynchronous.WaitForMainThread), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE3(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(Loxodon.Framework.Asynchronous.WaitForBackgroundThread), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE4(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.CustomYieldInstruction), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE5(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.AsyncOperation), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE6(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.ResourceRequest), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE7(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.AssetBundleRequest), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE8(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.AssetBundleCreateRequest), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE9(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.Networking.UnityWebRequestAsyncOperation), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE10(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(Loxodon.Framework.Asynchronous.IAsyncResult), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE11(Loxodon.Framework.Asynchronous.CoroutineAwaiterExtensions.GetAwaiter)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
