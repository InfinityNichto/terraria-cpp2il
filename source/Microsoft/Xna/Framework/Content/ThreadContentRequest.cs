using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	// Token: 0x020002F0 RID: 752
	[global::Cpp2ILInjected.Token(Token = "0x20003C6")]
	public class ThreadContentRequest
	{
		// Token: 0x060018CA RID: 6346 RVA: 0x000264BC File Offset: 0x000246BC
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

		// Token: 0x060018CB RID: 6347 RVA: 0x000264BF File Offset: 0x000246BF
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

		// Token: 0x060018CC RID: 6348 RVA: 0x000264C2 File Offset: 0x000246C2
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

		// Token: 0x060018CD RID: 6349 RVA: 0x000264C5 File Offset: 0x000246C5
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

		// Token: 0x060018CE RID: 6350 RVA: 0x000264C8 File Offset: 0x000246C8
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

		// Token: 0x060018CF RID: 6351 RVA: 0x000264CB File Offset: 0x000246CB
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

		// Token: 0x060018D0 RID: 6352 RVA: 0x000264CE File Offset: 0x000246CE
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

		// Token: 0x060018D1 RID: 6353 RVA: 0x000264D1 File Offset: 0x000246D1
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

		// Token: 0x060018D2 RID: 6354 RVA: 0x000264D4 File Offset: 0x000246D4
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

		// Token: 0x060018D3 RID: 6355 RVA: 0x000264D7 File Offset: 0x000246D7
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

		// Token: 0x060018D4 RID: 6356 RVA: 0x000264DA File Offset: 0x000246DA
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

		// Token: 0x060018D5 RID: 6357 RVA: 0x000264DD File Offset: 0x000246DD
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

		// Token: 0x060018D6 RID: 6358 RVA: 0x000264E0 File Offset: 0x000246E0
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

		// Token: 0x04002154 RID: 8532
		[global::Cpp2ILInjected.Token(Token = "0x40027C2")]
		private static ConcurrentQueue<ThreadContentRequest> _pendingRequests;

		// Token: 0x04002155 RID: 8533
		[global::Cpp2ILInjected.Token(Token = "0x40027C3")]
		private static List<ThreadContentRequest> _activeRequests;

		// Token: 0x04002156 RID: 8534
		[global::Cpp2ILInjected.Token(Token = "0x40027C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _lockObject;

		// Token: 0x04002157 RID: 8535
		[global::Cpp2ILInjected.Token(Token = "0x40027C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _asset;

		// Token: 0x04002158 RID: 8536
		[global::Cpp2ILInjected.Token(Token = "0x40027C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string _asset2;

		// Token: 0x04002159 RID: 8537
		[global::Cpp2ILInjected.Token(Token = "0x40027C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _asset3;

		// Token: 0x0400215A RID: 8538
		[global::Cpp2ILInjected.Token(Token = "0x40027C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ResourceRequest _loadRequest;

		// Token: 0x0400215B RID: 8539
		[global::Cpp2ILInjected.Token(Token = "0x40027C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ResourceRequest _loadRequest2;

		// Token: 0x0400215C RID: 8540
		[global::Cpp2ILInjected.Token(Token = "0x40027CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ResourceRequest _loadRequest3;

		// Token: 0x0400215D RID: 8541
		[global::Cpp2ILInjected.Token(Token = "0x40027CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::UnityEngine.Object _resource;

		// Token: 0x0400215E RID: 8542
		[global::Cpp2ILInjected.Token(Token = "0x40027CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::UnityEngine.Object _resource2;

		// Token: 0x0400215F RID: 8543
		[global::Cpp2ILInjected.Token(Token = "0x40027CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::UnityEngine.Object _resource3;

		// Token: 0x04002160 RID: 8544
		[global::Cpp2ILInjected.Token(Token = "0x40027CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _loaded;

		// Token: 0x04002161 RID: 8545
		[global::Cpp2ILInjected.Token(Token = "0x40027CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ThreadContentRequest.ObjectCreate _createFunction;

		// Token: 0x04002162 RID: 8546
		[global::Cpp2ILInjected.Token(Token = "0x40027D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ThreadContentRequest.ObjectCreate2 _createFunction2;

		// Token: 0x04002163 RID: 8547
		[global::Cpp2ILInjected.Token(Token = "0x40027D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ThreadContentRequest.ObjectCreate3 _createFunction3;

		// Token: 0x04002164 RID: 8548
		[global::Cpp2ILInjected.Token(Token = "0x40027D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private object _constructedObject;

		// Token: 0x02000835 RID: 2101
		// (Invoke) Token: 0x06004957 RID: 18775
		[global::Cpp2ILInjected.Token(Token = "0x20003C7")]
		public delegate object ObjectCreate(global::UnityEngine.Object asset);

		// Token: 0x02000836 RID: 2102
		// (Invoke) Token: 0x0600495B RID: 18779
		[global::Cpp2ILInjected.Token(Token = "0x20003C8")]
		public delegate object ObjectCreate2(global::UnityEngine.Object asset, global::UnityEngine.Object asset2);

		// Token: 0x02000837 RID: 2103
		// (Invoke) Token: 0x0600495F RID: 18783
		[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
		public delegate object ObjectCreate3(global::UnityEngine.Object asset, global::UnityEngine.Object asset2, global::UnityEngine.Object asset3);
	}
}
