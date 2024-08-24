using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameInput
{
	// Token: 0x020004B6 RID: 1206
	[global::Cpp2ILInjected.Token(Token = "0x20006CE")]
	public class SmartSelectGamepadPointer
	{
		// Token: 0x0600348B RID: 13451 RVA: 0x0002B628 File Offset: 0x00029828
		[global::Cpp2ILInjected.Token(Token = "0x60039F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x146FFC8", Offset = "0x146FFC8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheckWrapped", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartSelectGamepadPointer), Member = "SmartSelectLookup_GetTargetTile", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartCursorIsUsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool ShouldBeUsed()
		{
			throw null;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x0002B62B File Offset: 0x0002982B
		[global::Cpp2ILInjected.Token(Token = "0x60039FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1470078", Offset = "0x1470078", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SmartSelectLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmartSelectGamepadPointer), Member = "ShouldBeUsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmartSelectGamepadPointer), Member = "GetPointerPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void SmartSelectLookup_GetTargetTile(Player player, out int tX, out int tY)
		{
			throw null;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x0002B62E File Offset: 0x0002982E
		[global::Cpp2ILInjected.Token(Token = "0x60039FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14704D0", Offset = "0x14704D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateSize(Vector2 size)
		{
			throw null;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x0002B631 File Offset: 0x00029831
		[global::Cpp2ILInjected.Token(Token = "0x60039FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14704D8", Offset = "0x14704D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateCenter(Vector2 center)
		{
			throw null;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x0002B634 File Offset: 0x00029834
		[global::Cpp2ILInjected.Token(Token = "0x60039FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1470308", Offset = "0x1470308", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCursor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceSmartSelectCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartSelectGamepadPointer), Member = "SmartSelectLookup_GetTargetTile", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Vector2 GetPointerPosition()
		{
			throw null;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x0002B637 File Offset: 0x00029837
		[global::Cpp2ILInjected.Token(Token = "0x60039FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14704E0", Offset = "0x14704E0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SmartSelectGamepadPointer()
		{
			throw null;
		}

		// Token: 0x04006612 RID: 26130
		[global::Cpp2ILInjected.Token(Token = "0x4007A2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Vector2 _size;

		// Token: 0x04006613 RID: 26131
		[global::Cpp2ILInjected.Token(Token = "0x4007A30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Vector2 _center;

		// Token: 0x04006614 RID: 26132
		[global::Cpp2ILInjected.Token(Token = "0x4007A31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 _distUniform;
	}
}
