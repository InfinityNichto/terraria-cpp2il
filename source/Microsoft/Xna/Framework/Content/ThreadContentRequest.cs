using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	[global::Cpp2ILInjected.Token(Token = "0x20003C6")]
	public class ThreadContentRequest
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A0F40", Offset = "0x15A0F40", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "ConstructFromMainThread", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T ConstructOnMainThread<T>(string asset, ThreadContentRequest.ObjectCreate createFunction) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A1068", Offset = "0x15A1068", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "ConstructFromMainThread", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T ConstructOnMainThread<T>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A1198", Offset = "0x15A1198", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "ConstructFromMainThread", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T ConstructOnMainThread<T>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A50")]
		[global::Cpp2ILInjected.Address(RVA = "0xB48F50", Offset = "0xB48F50", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "LoadFromMainThread", ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::UnityEngine.Object Load(string asset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A51")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4914C", Offset = "0xB4914C", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "UpdateAysncLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "BeginLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "UpdateLoad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void UpdatingLoading()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A52")]
		[global::Cpp2ILInjected.Address(RVA = "0xB48FF0", Offset = "0xB48FF0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ThreadContentRequest(string asset, ThreadContentRequest.ObjectCreate createFunction = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A53")]
		[global::Cpp2ILInjected.Address(RVA = "0xB495BC", Offset = "0xB495BC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate2)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ThreadContentRequest(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A54")]
		[global::Cpp2ILInjected.Address(RVA = "0xB49644", Offset = "0xB49644", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate3)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ThreadContentRequest(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A55")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4938C", Offset = "0xB4938C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "UpdatingLoading", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ResourceRequest))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private void BeginLoad()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A56")]
		[global::Cpp2ILInjected.Address(RVA = "0xB493F0", Offset = "0xB493F0", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "UpdatingLoading", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncOperation), Member = "get_isDone", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceRequest), Member = "get_asset", ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool UpdateLoad()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A57")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4906C", Offset = "0xB4906C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public global::UnityEngine.Object LoadFromMainThread()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A58")]
		[global::Cpp2ILInjected.Address(RVA = "0xB496D4", Offset = "0xB496D4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate2)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadContentRequest), Member = "ConstructOnMainThread", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ThreadContentRequest.ObjectCreate3)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public object ConstructFromMainThread()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A59")]
		[global::Cpp2ILInjected.Address(RVA = "0xB497B4", Offset = "0xB497B4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static ThreadContentRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40027C2")]
		private static ConcurrentQueue<ThreadContentRequest> _pendingRequests;

		[global::Cpp2ILInjected.Token(Token = "0x40027C3")]
		private static List<ThreadContentRequest> _activeRequests;

		[global::Cpp2ILInjected.Token(Token = "0x40027C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _lockObject;

		[global::Cpp2ILInjected.Token(Token = "0x40027C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _asset;

		[global::Cpp2ILInjected.Token(Token = "0x40027C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string _asset2;

		[global::Cpp2ILInjected.Token(Token = "0x40027C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _asset3;

		[global::Cpp2ILInjected.Token(Token = "0x40027C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ResourceRequest _loadRequest;

		[global::Cpp2ILInjected.Token(Token = "0x40027C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ResourceRequest _loadRequest2;

		[global::Cpp2ILInjected.Token(Token = "0x40027CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ResourceRequest _loadRequest3;

		[global::Cpp2ILInjected.Token(Token = "0x40027CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::UnityEngine.Object _resource;

		[global::Cpp2ILInjected.Token(Token = "0x40027CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::UnityEngine.Object _resource2;

		[global::Cpp2ILInjected.Token(Token = "0x40027CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::UnityEngine.Object _resource3;

		[global::Cpp2ILInjected.Token(Token = "0x40027CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _loaded;

		[global::Cpp2ILInjected.Token(Token = "0x40027CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ThreadContentRequest.ObjectCreate _createFunction;

		[global::Cpp2ILInjected.Token(Token = "0x40027D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ThreadContentRequest.ObjectCreate2 _createFunction2;

		[global::Cpp2ILInjected.Token(Token = "0x40027D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ThreadContentRequest.ObjectCreate3 _createFunction3;

		[global::Cpp2ILInjected.Token(Token = "0x40027D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object _constructedObject;

		[global::Cpp2ILInjected.Token(Token = "0x20003C7")]
		public delegate object ObjectCreate(global::UnityEngine.Object asset);

		[global::Cpp2ILInjected.Token(Token = "0x20003C8")]
		public delegate object ObjectCreate2(global::UnityEngine.Object asset, global::UnityEngine.Object asset2);

		[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
		public delegate object ObjectCreate3(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, global::UnityEngine.Object asset3);
	}
}
