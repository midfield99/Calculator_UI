from ast import literal_eval
#needed to convert strings to ints.
# according to documentation literal_eval
# can only be used to parse data, input
# does not need to be sanitized.

from calc import *
import argparse
import ast

#takes a list and converts it to an expression.
def convert_list(li):
	problem = Expr(li[0])

	for item in li[1:]:
		if type(item) is list:
			problem.add_args(convert_list(item))
		else:
			problem.add_args(Expr(item))

	return problem

#takes a string with brackets and parenthesis and returns an Expr()
def string_to_expr(s):
	return convert_list(ast.literal_eval(s))

#checks if string is a number
def is_real_num(s):
	num_ops = ['-', '+', '.']
	num_chars = ['-', '.']
	if s in num_ops:
		return False
	for c in s:
		if not c.isdigit() and c not in num_chars:
			return False

	return True

def format_string(atom):
	if is_real_num(atom):
		return float(atom)
	else:
		return str(atom)

#creates an Expr() from a string with no brackets/parenthesis
# Expr().valid should do the testing, and other errors (such as divide by zero)
# should be caught by calc(). So this should return an invalid Expr() if s is invalid.
# But some assumptions are made, so this and calc() might return different error messages.
def pure_string_to_expr(s, start = 0, end = None, eval_expr = None):
	arg_num = 0
	atom = ""
	i = start
	if end == None:
		end = len(s)

	while i < end:
		#a space signifies a new atom, but we don't want to create a new atom if there is no old one.
		if arg_num == 2:
			return (eval_expr, i - 1)
		if s[i] == ' ' and atom != "":
			if eval_expr == None:
				eval_expr = Expr(format_string(atom))
				atom = ""

			else:
				if is_real_num(atom):
					eval_expr.add_args(Expr(format_string(atom)))
					arg_num += 1
					atom = ""

				#all non-number atoms are assumed to be operators.
				#not entirely safe assumption, but it's true if the string is valid.
				else:
					expr_new, i = pure_string_to_expr(s, i, end, Expr(format_string(atom)))
					atom = ""
					eval_expr.add_args(expr_new)
					arg_num += 1

		elif s[i] != ' ':
			atom += s[i]
		
		i+= 1

	if eval_expr == None:
		eval_expr = Expr(format_string(atom))

	if atom != "":
		eval_expr.add_args(Expr(format_string(atom)))

	return (eval_expr, i -1)

#wrapper for calc. Calc takes an Expr object, so literal_eval doesn't really work well.
def calc_string(s):
	return calc(string_to_expr(s))

#wrapper for calc
def calc_pure_string(s):
	eval_expr = pure_string_to_expr(s)[0]
	res = calc(eval_expr)
	return res

def calc_pure_string_verify(s):
	eval_expr = pure_string_to_expr(s)[0]
	return eval_expr.valid()




def cmd_args():
	parser = argparse.ArgumentParser()
	parser.add_argument("function", help="function: the name of the function you want to call (string)")
	parser.add_argument("arg_list", help="arg_list:the string that will be converted to an expression.\n\
		If --direct literal_eval(string) should be an arguement dictionary.\n\
		For example: function(**literal_eval(arg_list)) should be a valid call.")
	parser.add_argument("--direct", help="directly call the function.", action='store_true')

	return parser.parse_args()

#main code for calling python methods from the command line.
def main():
	args = cmd_args()
	#directly calls the function.
	#arguement types for function calls are limited to output types for literal_eval
	if args.direct:
		print globals()[args.function](**literal_eval(args.arg_list))
	#uses args.function as a flag to call a specified function.
	else:
		if args.function == "test_calc":
			print calc(string_to_expr(args.arg_list))

		elif args.function == "test_calc_pure":
			print calc_pure_string(args.arg_list)

		elif args.function == "test_verify":
			print calc_pure_string_verify(args.arg_list)


if __name__ == "__main__":
    main()