using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000771")]
	public struct CameraInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003E6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B68B8", Offset = "0x14B68B8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CameraModifierStack), Member = "ApplyTo", MemberParameters = new object[] { typeof(ref Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ScreenSize", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CameraInfo(Vector2 position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007D21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 CameraPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007D22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 OriginalCameraCenter;

		[global::Cpp2ILInjected.Token(Token = "0x4007D23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Vector2 OriginalCameraPosition;
	}
}
