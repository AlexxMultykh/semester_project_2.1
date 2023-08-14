﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/alexmultykh/Desktop/uni/2_semester/programs 2/semesterProject2/semesterProject2/Content/language.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace semesterProject2.Content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="languageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IlanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>valueExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueExpression([NotNull] languageParser.ValueExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>valueExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueExpression([NotNull] languageParser.ValueExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] languageParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] languageParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] languageParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] languageParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] languageParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] languageParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] languageParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>additiveExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] languageParser.AdditiveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] languageParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] languageParser.ComparisonExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] languageParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] languageParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] languageParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] languageParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] languageParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] languageParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] languageParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] languageParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfCondition([NotNull] languageParser.IfConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.ifCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfCondition([NotNull] languageParser.IfConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] languageParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] languageParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.whileLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileLoop([NotNull] languageParser.WhileLoopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.whileLoop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileLoop([NotNull] languageParser.WhileLoopContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] languageParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] languageParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] languageParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] languageParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] languageParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] languageParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.mulOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulOp([NotNull] languageParser.MulOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.mulOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulOp([NotNull] languageParser.MulOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] languageParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] languageParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.compOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompOp([NotNull] languageParser.CompOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.compOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompOp([NotNull] languageParser.CompOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] languageParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] languageParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] languageParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] languageParser.ValueContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="languageParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] languageParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="languageParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] languageParser.BlockContext context);
}
} // namespace semesterProject2.Content