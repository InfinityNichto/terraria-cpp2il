﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

namespace Controller
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B5B")]
	public class ControllerActionVector
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000932")]
		public ControllerActionAxis MappedX
		{
			[global::Cpp2ILInjected.Token(Token = "0x600547D")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B8D4", Offset = "0x94B8D4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000933")]
		public ControllerActionAxis MappedY
		{
			[global::Cpp2ILInjected.Token(Token = "0x600547E")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B9E0", Offset = "0x94B9E0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000934")]
		public bool HasMapping
		{
			[global::Cpp2ILInjected.Token(Token = "0x600547F")]
			[global::Cpp2ILInjected.Address(RVA = "0x94B948", Offset = "0x94B948", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "get_HasMapping", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlsButtonTagHandler), Member = "DrawAxisControl", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(Microsoft.Xna.Framework.Graphics.Color),
				typeof(float),
				typeof(ControllerActionVector),
				typeof(bool)
			}, ReturnType = typeof(int))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.Action),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionVector),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "get_MappedX", ReturnType = typeof(ControllerActionAxis))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "get_MappedY", ReturnType = typeof(ControllerActionAxis))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000935")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005480")]
			[global::Cpp2ILInjected.Address(RVA = "0x94BA54", Offset = "0x94BA54", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
			{
				typeof(GUIControlsBanner.ActionSource),
				typeof(ControllerActionVector),
				typeof(string),
				typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
				typeof(Rectangle),
				typeof(TransactionButton_Layout),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000936")]
		public bool HasMappingExcludeLinked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005481")]
			[global::Cpp2ILInjected.Address(RVA = "0x94BADC", Offset = "0x94BADC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000937")]
		public ControllerActionButton.RequiredButtonState RequiredStateExcludeLinked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005482")]
			[global::Cpp2ILInjected.Address(RVA = "0x94BB44", Offset = "0x94BB44", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005483")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BBA4", Offset = "0x94BBA4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		public bool Active(ControllerDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005484")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BBF4", Offset = "0x94BBF4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
		{
			typeof(GUIControlsBanner.ActionSource),
			typeof(ControllerActionVector),
			typeof(string),
			typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
			typeof(Rectangle),
			typeof(TransactionButton_Layout),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		public bool RequiredStateValid(ControllerDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005485")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BC34", Offset = "0x94BC34", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISlider), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Slider_Layout),
			typeof(bool),
			typeof(ref float),
			typeof(GUISlider.DragState),
			typeof(GUISlider.DrawBackingHandler),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::UnityEngine.Vector2 GetValue(ControllerDevice controller)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005486")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BD94", Offset = "0x94BD94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "CreateVectorMapping", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ControllerActionAxis),
			typeof(ControllerActionAxis)
		}, ReturnType = typeof(ControllerActionVector))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControllerActionVector()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008D4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Id;

		[global::Cpp2ILInjected.Token(Token = "0x4008D50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControllerActionAxis X;

		[global::Cpp2ILInjected.Token(Token = "0x4008D51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ControllerActionAxis Y;

		[global::Cpp2ILInjected.Token(Token = "0x4008D52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int DisplayPriority;

		[global::Cpp2ILInjected.Token(Token = "0x4008D53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ControllerActionVector LinkedAction;

		[global::Cpp2ILInjected.Token(Token = "0x4008D54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public bool Enabled;

		[global::Cpp2ILInjected.Token(Token = "0x4008D55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		public bool DisabledUntilClear;
	}
}
