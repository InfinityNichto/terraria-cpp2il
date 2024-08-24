using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x0200073D RID: 1853
	[global::Cpp2ILInjected.Token(Token = "0x2000B3D")]
	public class RejectedAssetCollection
	{
		// Token: 0x0600471C RID: 18204 RVA: 0x0002EB50 File Offset: 0x0002CD50
		[global::Cpp2ILInjected.Token(Token = "0x60053D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x945AA4", Offset = "0x945AA4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "RejectAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "RejectAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = "RejectAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "RejectAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reject(string assetPath, IRejectionReason reason)
		{
			throw null;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0002EB53 File Offset: 0x0002CD53
		[global::Cpp2ILInjected.Token(Token = "0x60053D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x945B04", Offset = "0x945B04", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "HasAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsRejected(string assetPath)
		{
			throw null;
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x0002EB56 File Offset: 0x0002CD56
		[global::Cpp2ILInjected.Token(Token = "0x60053D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x945B5C", Offset = "0x945B5C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "ClearRejections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "ClearRejections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = "ClearRejections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "ClearRejections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x0002EB59 File Offset: 0x0002CD59
		[global::Cpp2ILInjected.Token(Token = "0x60053D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x945BA4", Offset = "0x945BA4", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw null;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		[global::Cpp2ILInjected.Token(Token = "0x60053D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x945DEC", Offset = "0x945DEC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RejectedAssetCollection()
		{
			throw null;
		}

		// Token: 0x04007358 RID: 29528
		[global::Cpp2ILInjected.Token(Token = "0x4008CF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, IRejectionReason> _rejectedAssetsAndReasons;
	}
}
