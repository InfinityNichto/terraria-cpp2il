using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A7 RID: 679
	[global::Cpp2ILInjected.Token(Token = "0x200036D")]
	public class SpriteEffect : Effect
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x00025AE7 File Offset: 0x00023CE7
		[global::Cpp2ILInjected.Token(Token = "0x60016DD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAA080", Offset = "0xAAA080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		public SpriteEffect(GraphicsDevice device)
		{
			throw null;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00025AEA File Offset: 0x00023CEA
		[global::Cpp2ILInjected.Token(Token = "0x170002AE")]
		public static SpriteEffect Effect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016DE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAA088", Offset = "0xAAA088", Length = "0x2A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "LoadUnityResource", MemberTypeParameters = new object[] { "ResourceType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "ResourceType")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(int),
				typeof(string),
				typeof(Material)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectPass[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectTechnique), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(string),
				typeof(EffectPassCollection)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04001F46 RID: 8006
		[global::Cpp2ILInjected.Token(Token = "0x400256B")]
		private static SpriteEffect _effect;
	}
}
