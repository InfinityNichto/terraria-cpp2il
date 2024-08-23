using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	// Token: 0x02000014 RID: 20
	[StaticAccessor("AndroidAssetPacksBindingsHelpers", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	public static class AndroidAssetPacks
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002305 File Offset: 0x00000505
		[global::Cpp2ILInjected.Token(Token = "0x6000183")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F659C0", Offset = "0x1F659C0", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidAssetPacks.AssetPackManagerStatusQueryCallback), Member = "onStatusResult", MemberParameters = new object[]
		{
			typeof(long),
			typeof(string[]),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "CallStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static AndroidJavaObject GetAssetPackManager()
		{
			throw null;
		}

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		private static bool s_ApiMissing;

		// Token: 0x02000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x2000015")]
		private class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
		{
			// Token: 0x0600019A RID: 410 RVA: 0x0000234A File Offset: 0x0000054A
			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F65CD4", Offset = "0x1F65CD4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public AssetPackManagerDownloadStatusCallback(Action<AndroidAssetPackInfo> callback, string[] assetPacks)
			{
				throw null;
			}

			// Token: 0x0600019B RID: 411 RVA: 0x0000234D File Offset: 0x0000054D
			[Preserve]
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F65D58", Offset = "0x1F65D58", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Contains", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode)
			{
				throw null;
			}

			// Token: 0x04000056 RID: 86
			[global::Cpp2ILInjected.Token(Token = "0x4000041")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Action<AndroidAssetPackInfo> m_Callback;

			// Token: 0x04000057 RID: 87
			[global::Cpp2ILInjected.Token(Token = "0x4000042")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string[] m_AssetPacks;
		}

		// Token: 0x02000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x2000016")]
		private class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
		{
			// Token: 0x0600019C RID: 412 RVA: 0x00002350 File Offset: 0x00000550
			[global::Cpp2ILInjected.Token(Token = "0x6000186")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F65E64", Offset = "0x1F65E64", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public AssetPackManagerMobileDataConfirmationCallback(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
			{
				throw null;
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00002353 File Offset: 0x00000553
			[Preserve]
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F65EE4", Offset = "0x1F65EE4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void onMobileDataConfirmationResult(bool allowed)
			{
				throw null;
			}

			// Token: 0x04000058 RID: 88
			[global::Cpp2ILInjected.Token(Token = "0x4000043")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback;
		}

		// Token: 0x02000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x2000017")]
		private class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
		{
			// Token: 0x0600019E RID: 414 RVA: 0x00002356 File Offset: 0x00000556
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F65F68", Offset = "0x1F65F68", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public AssetPackManagerStatusQueryCallback(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks)
			{
				throw null;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00002359 File Offset: 0x00000559
			[Preserve]
			[global::Cpp2ILInjected.Token(Token = "0x6000189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F66058", Offset = "0x1F66058", Length = "0x2D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidAssetPacks), Member = "GetAssetPackManager", ReturnType = typeof(AndroidJavaObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes)
			{
				throw null;
			}

			// Token: 0x04000059 RID: 89
			[global::Cpp2ILInjected.Token(Token = "0x4000044")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private Action<ulong, AndroidAssetPackState[]> m_Callback;

			// Token: 0x0400005A RID: 90
			[global::Cpp2ILInjected.Token(Token = "0x4000045")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private List<string> m_AssetPackNames;

			// Token: 0x0400005B RID: 91
			[global::Cpp2ILInjected.Token(Token = "0x4000046")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private List<AndroidAssetPackState> m_States;

			// Token: 0x0400005C RID: 92
			[global::Cpp2ILInjected.Token(Token = "0x4000047")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private long m_Size;
		}
	}
}
