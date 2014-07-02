using CoreGraphics;
using ObjectiveC;
        bool LayoutManagerBreakLineByWordBeforeCharacterAtIndex(NSLayoutManager layoutManager, int shouldBreakLineByWordBeforeCharacterAtIndex);
        CGFloat LayoutManagerParagraphSpacingBeforeGlyphAtIndex(NSLayoutManager layoutManager, int paragraphSpacingBeforeGlyphAtIndex, CGRect withProposedLineFragmentRect);
        CGRect LayoutManagerBoundingBoxForControlGlyphAtIndex(NSLayoutManager layoutManager, int boundingBoxForControlGlyphAtIndex, NSTextContainer forTextContainer, CGRect proposedLineFragment, CGPoint glyphPosition, int characterIndex);
        void LayoutManagerDidCompleteLayoutForTextContainer(NSLayoutManager layoutManager, NSTextContainer didCompleteLayoutForTextContainer, bool atEnd);
        void LayoutManagerWithTextContainer(NSLayoutManager layoutManager, NSTextContainer textContainer, CGSize didChangeGeometryFromSize);
        int LayoutManagerShouldGenerateGlyphs(NSLayoutManager layoutManager, CConstPointer<CGGlyph> shouldGenerateGlyphs, CConstPointer<NSGlyphProperty> properties, CConstPointer<int> characterIndexes, UIFont font, NSRange forGlyphRange);
        NSControlCharacterAction LayoutManagerShouldUseAction(NSLayoutManager layoutManager, NSControlCharacterAction shouldUseAction, int forControlCharacterAtIndex);