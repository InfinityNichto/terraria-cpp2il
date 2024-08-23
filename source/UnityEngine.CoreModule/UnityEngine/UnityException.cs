using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x0600030B RID: 779 RVA: 0x00002659 File Offset: 0x00000859
		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CB3C", Offset = "0x1F7CB3C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public UnityException()
		{
			throw null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000265C File Offset: 0x0000085C
		[global::Cpp2ILInjected.Token(Token = "0x600031B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6FAC8", Offset = "0x1F6FAC8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new object[] { typeof(Texture) }, ReturnType = typeof(UnityException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "CreateNativeArrayLengthOverflowException", ReturnType = typeof(UnityException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Cubemap),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture3D), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture3D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(Texture2DArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CubemapArray), Member = "Internal_Create", MemberParameters = new object[]
		{
			typeof(CubemapArray),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(GraphicsFormat),
			typeof(TextureCreationFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoBehaviour), Member = "InvokeRepeating", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnityException(string message)
		{
			throw null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000265F File Offset: 0x0000085F
		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7CBBC", Offset = "0x1F7CBBC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected UnityException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
