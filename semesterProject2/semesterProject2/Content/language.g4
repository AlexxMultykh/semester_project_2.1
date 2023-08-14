grammar language;

program: line* EOF;  // 0 or more lines, followed by End Of File

line: statement | ifCondition | whileLoop;

statement: (assignment|functionCall);

ifCondition: 'If' expression 'do' block ('Else do' elseIfBlock)?; // question mark means that elseBlock is optional

elseIfBlock: block | ifCondition;

whileLoop: 'While' expression 'do' block ('Else do' elseIfBlock)?;

assignment: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

IDENTIFIER: [a-zA-Z_][a-zA-Z0-9]*;

expression
    : value                             #valueExpression
    | IDENTIFIER                        #identifierExpression
    | functionCall                      #functionCallExpression
    | expression mulOp expression       #multiplicativeExpression
    | expression addOp expression       #additiveExpression
    | expression compOp expression      #comparisonExpression
    | expression boolOp expression      #booleanExpression
    ; 
    
// The order is important, since it is a recursive call. 
// Multiplication is first, since if we have something like 
// (var i = i + 2 * 4), we first multiply 2 by 4 and then add to i

mulOp: '*' | '/' | '%' ;
addOp: '+' | '-' ;
compOp: '==' | '!=' | '>' | '>=' | '<' | '<='  ;
boolOp: 'and' | 'or' | 'xor' ;

value: INTEGER | FLOAT | STRING | BOOL | NULL;

INTEGER: [0-9]+ ;
FLOAT: [0-9]+ '.' [0-9]+ ;
STRING: ('"' ~'"'* '"') | ('\'' ~'\''* '\''); // quotes { any number of NON-quotes characters (~'"'*) } quotes OR 
                                              // construction that looks like (var s = "Name 'Nickname' Surname")
BOOL: 'true' | 'false';
NULL: 'null';

block: '{' line* '}';

WS: [\t\r\n]+ -> skip;      // skip any whitespaces

