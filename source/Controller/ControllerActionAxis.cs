using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;
using UnityEngine;

namespace Controller
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B54")]
	public class ControllerActionAxis
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700092C")]
		public bool HasMapping
		{
			[global::Cpp2ILInjected.Token(Token = "0x600545A")]
			[global::Cpp2ILInjected.Address(RVA = "0x94919C", Offset = "0x94919C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600545B")]
		[global::Cpp2ILInjected.Address(RVA = "0x9491E4", Offset = "0x9491E4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool RequiredStateValid(ControllerDevice controller)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600545C")]
		[global::Cpp2ILInjected.Address(RVA = "0x949410", Offset = "0x949410", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Active", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Active(ControllerDevice controller)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700092D")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600545D")]
			[global::Cpp2ILInjected.Address(RVA = "0x949280", Offset = "0x949280", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner.Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionVector),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "get_RequiredStateExcludeLinked", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700092E")]
		public ControllerActionAxis.Entry FirstEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x600545E")]
			[global::Cpp2ILInjected.Address(RVA = "0x9492D4", Offset = "0x9492D4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(float),
				typeof(ControllerActionVector),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(SpriteFont),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(float),
				typeof(ref SpriteFont.CharacterSource),
				typeof(int),
				typeof(ref int),
				typeof(ref Microsoft.Xna.Framework.Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsKeyboardTagHandler), Member = "MeasureInlineMapping", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(ref SpriteFont.CharacterSource),
				typeof(int),
				typeof(ref int),
				typeof(ref Microsoft.Xna.Framework.Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner.Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionVector),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "GetControlTag", MemberParameters = new object[] { typeof(ControllerActionVector) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "get_Binding", ReturnType = typeof(KeyCode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "set_Binding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "LoadDefaults", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "ClearBinding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600545F")]
		[global::Cpp2ILInjected.Address(RVA = "0x949AA0", Offset = "0x949AA0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapAxis(Axis axis, float threshold = 0f, ControllerActionButton.RequiredButtonState requiredButtonState = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005460")]
		[global::Cpp2ILInjected.Address(RVA = "0x949B94", Offset = "0x949B94", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapMultipleAxis(Axis axis1, Axis axis2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005461")]
		[global::Cpp2ILInjected.Address(RVA = "0x949C74", Offset = "0x949C74", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapButtons(Buttons button0, Buttons button1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005462")]
		[global::Cpp2ILInjected.Address(RVA = "0x949D54", Offset = "0x949D54", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MapKeys(KeyCode key0, KeyCode key1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005463")]
		[global::Cpp2ILInjected.Address(RVA = "0x9494E4", Offset = "0x9494E4", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisTime", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "ConsumeModifiers", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisScaled", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "HasButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public float GetValue(ControllerDevice controller)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005464")]
		[global::Cpp2ILInjected.Address(RVA = "0x949E9C", Offset = "0x949E9C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearWorldMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearInventoryMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005465")]
		[global::Cpp2ILInjected.Address(RVA = "0x949F04", Offset = "0x949F04", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "CreateAxisMapping", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(float)
		}, ReturnType = typeof(ControllerActionAxis))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ControllerActionAxis()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008D26")]
		public static float ElapsedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4008D27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Id;

		[global::Cpp2ILInjected.Token(Token = "0x4008D28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool Enabled;

		[global::Cpp2ILInjected.Token(Token = "0x4008D29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool TimeBased;

		[global::Cpp2ILInjected.Token(Token = "0x4008D2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float Scale;

		[global::Cpp2ILInjected.Token(Token = "0x4008D2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<ControllerActionAxis.Entry> _entries;

		[global::Cpp2ILInjected.Token(Token = "0x2000B55")]
		public class Entry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005466")]
			[global::Cpp2ILInjected.Address(RVA = "0x949B8C", Offset = "0x949B8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Entry()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008D2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ControllerActionAxis.Entry.Type MappingType;

			[global::Cpp2ILInjected.Token(Token = "0x4008D2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public Axis Axis0;

			[global::Cpp2ILInjected.Token(Token = "0x4008D2E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Axis Axis1;

			[global::Cpp2ILInjected.Token(Token = "0x4008D2F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public float Threshold;

			[global::Cpp2ILInjected.Token(Token = "0x4008D30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Buttons Button0;

			[global::Cpp2ILInjected.Token(Token = "0x4008D31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public Buttons Button1;

			[global::Cpp2ILInjected.Token(Token = "0x4008D32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public KeyCode Key0;

			[global::Cpp2ILInjected.Token(Token = "0x4008D33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public KeyCode Key1;

			[global::Cpp2ILInjected.Token(Token = "0x4008D34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public ControllerActionButton.RequiredButtonState RequiredState;

			[global::Cpp2ILInjected.Token(Token = "0x2000B56")]
			public enum Type
			{
				[global::Cpp2ILInjected.Token(Token = "0x4008D36")]
				SingleAxis,
				[global::Cpp2ILInjected.Token(Token = "0x4008D37")]
				MultipleAxis,
				[global::Cpp2ILInjected.Token(Token = "0x4008D38")]
				Buttons,
				[global::Cpp2ILInjected.Token(Token = "0x4008D39")]
				Keys
			}
		}
	}
}
