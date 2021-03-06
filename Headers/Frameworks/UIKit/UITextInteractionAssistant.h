/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "UIGestureRecognizerDelegate-Protocol.h"

@class NSHashTable, NSMutableArray, NSMutableSet, UIFieldEditor, UIGestureRecognizer, UILongPressGestureRecognizer, UIResponder<UITextInput>, UITapGestureRecognizer, UITextChecker, UITextSelectionView;

@interface UITextInteractionAssistant : NSObject <UIGestureRecognizerDelegate>
{
    UIResponder<UITextInput> *_view;
    UITextSelectionView *_selectionView;
    NSMutableArray *_recognizers;
    NSMutableSet *_linkGestures;
    UILongPressGestureRecognizer *_loupeGesture;
    UITapGestureRecognizer *_singleTapGesture;
    UIGestureRecognizer *_doubleTapGesture;
    int _autoscrollRamp;
    double _autoscrollFactor;
    struct CGPoint _autoscrollBasePoint;
    struct CGPoint _autoscrollUntransformedExtentPoint;
    struct CGPoint _loupeGestureEndPoint;
    UITextChecker *_textChecker;
    _Bool _inGesture;
    _Bool _autoscrolled;
    _Bool _isTryingToHighlightLink;
    _Bool _externalTextInput;
    NSHashTable *_gestureRecognizerViews;
}

- (id)textSelectionView;
- (void)clearGestureRecognizers;
- (id)initWithResponder:(id)arg1;

// Remaining properties
@property(readonly, nonatomic) UIFieldEditor *fieldEditor; // @dynamic fieldEditor;
@property(retain, nonatomic) UITapGestureRecognizer *singleTapGesture; // @dynamic singleTapGesture;

@end

