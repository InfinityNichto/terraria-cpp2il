using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A9 RID: 681
	[global::Cpp2ILInjected.Token(Token = "0x200036F")]
	public class GeometryBuffer
	{
		// Token: 0x0600157D RID: 5501 RVA: 0x00025AFF File Offset: 0x00023CFF
		[global::Cpp2ILInjected.Token(Token = "0x60016E5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB50C", Offset = "0xAAB50C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GeometryBuffer(bool dynamic)
		{
			throw null;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00025B02 File Offset: 0x00023D02
		[global::Cpp2ILInjected.Token(Token = "0x60016E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B1B4", Offset = "0x158B1B4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private T[] Clone<T>(T[] srcArray, int Count)
		{
			throw null;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00025B05 File Offset: 0x00023D05
		[global::Cpp2ILInjected.Token(Token = "0x60016E7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB514", Offset = "0xAAB514", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
		{
			typeof(EffectPass),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_renderQueue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_material", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RenderAndFlush()
		{
			throw null;
		}

		// Token: 0x04001F54 RID: 8020
		[global::Cpp2ILInjected.Token(Token = "0x4002579")]
		public static int RenderLayer;

		// Token: 0x04001F55 RID: 8021
		[global::Cpp2ILInjected.Token(Token = "0x400257A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private GeometryBufferInstance _current;
	}
}
