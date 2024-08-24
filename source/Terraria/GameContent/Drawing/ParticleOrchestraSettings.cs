using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.Net;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000668 RID: 1640
	[global::Cpp2ILInjected.Token(Token = "0x20009E7")]
	public struct ParticleOrchestraSettings
	{
		// Token: 0x0600404F RID: 16463 RVA: 0x0002D7CA File Offset: 0x0002B9CA
		[global::Cpp2ILInjected.Token(Token = "0x6004ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A38BC", Offset = "0x8A38BC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "WriteVector2", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0002D7CD File Offset: 0x0002B9CD
		[global::Cpp2ILInjected.Token(Token = "0x6004ACD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A3970", Offset = "0x8A3970", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadVector2", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DeserializeFrom(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x04006D44 RID: 27972
		[global::Cpp2ILInjected.Token(Token = "0x400854D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 PositionInWorld;

		// Token: 0x04006D45 RID: 27973
		[global::Cpp2ILInjected.Token(Token = "0x400854E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 MovementVector;

		// Token: 0x04006D46 RID: 27974
		[global::Cpp2ILInjected.Token(Token = "0x400854F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int UniqueInfoPiece;

		// Token: 0x04006D47 RID: 27975
		[global::Cpp2ILInjected.Token(Token = "0x4008550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public byte IndexOfPlayerWhoInvokedThis;

		// Token: 0x04006D48 RID: 27976
		[global::Cpp2ILInjected.Token(Token = "0x4008551")]
		public const int SerializationSize = 21;
	}
}
