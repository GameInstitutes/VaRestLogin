// Copyright 2016 FinalSpark Gamestudios

using UnrealBuildTool;
using System.Collections.Generic;

public class SparkfireEditorTarget : TargetRules
{
	public SparkfireEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Sparkfire" } );
	}
}
