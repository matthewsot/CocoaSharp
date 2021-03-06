/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <QuartzCore/CATransaction.h>

@interface CATransaction (CATransactionPrivate)
+ (void)setInputTime:(double)arg1;
+ (double)inputTime;
+ (void)setCommitTime:(double)arg1;
+ (double)commitTime;
+ (void)setAnimatesFromModelValues:(_Bool)arg1;
+ (_Bool)animatesFromModelValues;
+ (unsigned int)currentState;
+ (void)synchronize;
+ (void)activateBackground:(_Bool)arg1;
+ (void)activate;
+ (id)animator;
+ (void)popAnimator;
+ (void)pushAnimator:(id)arg1;
@end

