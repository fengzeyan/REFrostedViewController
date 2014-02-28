using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libReFrostedMenu.a", LinkTarget.Simulator | LinkTarget.ArmV7, Frameworks = "QuartzCore CoreGraphics Accelerate", ForceLoad = true)]
