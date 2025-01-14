// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TechFellow.Optimizely.AdvancedContentArea.Providers;

public static class DisplayOptions
{
    public static List<DisplayModeFallback> Default
    {
        get
        {
            var initialData = new List<DisplayModeFallback>
            {
                new()
                {
                    Id = "full",
                    Name = "Full width (1/1)",
                    Tag = ContentAreaTags.FullWidth,
                    ExtraExtraLargeScreenWidth = 12,
                    ExtraLargeScreenWidth = 12,
                    LargeScreenWidth = 12,
                    MediumScreenWidth = 12,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--full"
                },
                new()
                {
                    Id = "half",
                    Name = "Half width (1/2)",
                    Tag = ContentAreaTags.HalfWidth,
                    ExtraExtraLargeScreenWidth = 6,
                    ExtraLargeScreenWidth = 6,
                    LargeScreenWidth = 6,
                    MediumScreenWidth = 6,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--half"
                },
                new()
                {
                    Id = "one-third",
                    Name = "One third width (1/3)",
                    Tag = ContentAreaTags.OneThirdWidth,
                    ExtraExtraLargeScreenWidth = 4,
                    ExtraLargeScreenWidth = 4,
                    LargeScreenWidth = 4,
                    MediumScreenWidth = 6,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--one-third"
                },
                new()
                {
                    Id = "two-thirds",
                    Name = "Two thirds width (2/3)",
                    Tag = ContentAreaTags.TwoThirdsWidth,
                    ExtraExtraLargeScreenWidth = 8,
                    ExtraLargeScreenWidth = 8,
                    LargeScreenWidth = 8,
                    MediumScreenWidth = 6,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--two-thirds"
                },
                new()
                {
                    Id = "one-quarter",
                    Name = "One quarter width (1/4)",
                    Tag = ContentAreaTags.OneQuarterWidth,
                    ExtraExtraLargeScreenWidth = 3,
                    ExtraLargeScreenWidth = 3,
                    LargeScreenWidth = 3,
                    MediumScreenWidth = 6,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--one-quarter"
                },
                new()
                {
                    Id = "three-quarters",
                    Name = "Three quarters width (3/4)",
                    Tag = ContentAreaTags.ThreeQuartersWidth,
                    ExtraExtraLargeScreenWidth = 9,
                    ExtraLargeScreenWidth = 9,
                    LargeScreenWidth = 9,
                    MediumScreenWidth = 6,
                    SmallScreenWidth = 12,
                    ExtraSmallScreenWidth = 12,
                    Icon = "epi-icon__layout--three-quarters"
                }
            };

            return initialData;
        }
    }
}
