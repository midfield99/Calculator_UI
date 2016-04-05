import unittest

from subprocess import Popen, PIPE
from calc_interface import *


class test_calc(unittest.TestCase):
	#calc.py tests, imported in calc_interface.py
	def test_add(self):
		expr1 = Expr('+', [Expr(2) , Expr(3)])
		self.assertTrue(expr1.evaluate() == 5)

	def test_interface_add_with_quotes(self):
		expr1 = Expr('+', [Expr('2') , Expr('3')])
		self.assertTrue(expr1.evaluate() == "Invalid arguement:Expr(start_symbol=2)")

	def test_subtract(self):
		expr1 = Expr('-', [Expr(2) , Expr(3)])
		self.assertTrue(expr1.evaluate() == -1)

	def test_multiply(self):
		expr1 = Expr('*', [Expr(2) , Expr(3)])
		self.assertTrue(expr1.evaluate() == 6)

	def test_divide(self):
		expr1 = Expr('/', [Expr(3) , Expr(2)])
		self.assertTrue(expr1.evaluate() == 1.5)

	def test_multi(self):
		expr1 = Expr('/', [Expr(3) , Expr(2)])
		expr2 = Expr('*', [expr1 , Expr(10)])
		expr3 = Expr('-', [expr2 , Expr(6)])
		expr4 = Expr('+', [expr3 , Expr(2)])
		self.assertTrue(expr4.evaluate() == 11)

	def test_divide_by_zero(self):
		expr1 = Expr('/', [Expr(3) , Expr(0)])
		self.assertTrue(calc(expr1) == "Cannot divide by zero.")

	def test_false_bad_arg(self):
		expr1 = Expr('+', [Expr('&') , Expr(2)])
		self.assertTrue(calc(expr1) == 'Invalid arguement 1:Expr(start_symbol=&)')

	def test_false_bad_op(self):
		expr1 = Expr('h', [Expr(1) , Expr(2)])
		self.assertTrue(calc(expr1) == "Invalid Operation:'h'")

	def test_false_bad_op_expr(self):
		expr1 = Expr(Expr(1), [Expr(1) , Expr(1)])
		self.assertTrue(calc(expr1) == 'Invalid Operation:Expr(start_symbol=1)')

	def test_missing_args(self):
		self.assertTrue(calc(Expr('+')) == "+ with no arguements is invalid.")

	#calc_interface.py tests
	def test_interface_add(self):
		str1 = "['+', 2 , 3]"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == 5)

	def test_interface_add_with_quotes(self):
		str1 = "['+', '2' , '3']"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == "Invalid arguement 1:Expr(start_symbol=2)")

	def test_interface_subtract(self):
		str1 = "['-', 2 , 3]"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == -1)

	def test_interface_multiply(self):
		str1 = "['*', 2 , 3]"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == 6)

	def test_interface_divide(self):
		str1 = "['/', 3 , 2]"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == 1.5)

	def test_interface_divide_by_zero(self):
		str1 = "['/', 2 , 0]"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == "Cannot divide by zero.")

	def test_interface_false_bad_arg(self):
		str1 = "['+', '&', 2]"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == 'Invalid arguement 1:Expr(start_symbol=&)')
	#note that test_pure_string_false_bad_arg gives a different error than
	# test_interface_false_bad_arg does. This is because the brackets in test_pure are implicit,
	# not explicit, and the result is different.
	def test_pure_string_false_bad_arg(self):
		str1 = "+ & 2"
		error ='Invalid arguement 1:Expr(start_symbol=&, arguements=[Expr(start_symbol=2.0)])'
		self.assertTrue(calc_pure_string(str1) == error)

	def test_interface_false_bad_op(self):
		str1 = "['h', '&', 2]"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == "Invalid Operation:'h'")

	#Note that the interface does not allow an expression to be put in as an operator.
	def test_interface_false_bad_op_expr(self):
		str1 = "['1', '1', 2]"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == "Invalid Operation:'1'")

	def test_interface_missing_args(self):
		str1 = "['+']"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == "+ with no arguements is invalid.")

	def test_interface_multi(self):
		str1 = "['+', ['-', ['*', ['/', 3, 2], 10],6], 2 ]"
		expr1 = string_to_expr(str1)
		self.assertTrue(expr1.evaluate() == 11)

	#tests for calls from command line
	def test_command_line(self):
		str1 = "['+', ['-', ['*', ['/', 3, 2], 10],6], 2 ]"
		cmd = ["python", "calc_interface.py", "test_calc", str1]
		p = Popen(cmd, stdout=PIPE, stderr=PIPE)
		out, err = p.communicate()
		self.assertTrue(float(out) == 11)

	#direct call on calc_string is kind of a pain because of the two literal_eval arguements
	def test_command_line_direct(self):
		str1 = "['+', ['-', ['*', ['/', 3, 2], 10],6], 2 ]"
		d = {"s": str1}
		cmd = ["python", "calc_interface.py", "calc_string", str(d), "--direct"]
		p = Popen(cmd, stdout=PIPE, stderr=PIPE)
		out, err = p.communicate()
		self.assertTrue(float(out) == 11)

	def test_pure_string_calc(self):
		str1 = "+ - * /  3 2  10 6 2 "
		self.assertTrue(calc_pure_string(str1) == 11)

	def test_pure_string_calc_neg(self):
		str1 = "+ - * /  3 2  10 6 -2 "
		self.assertTrue(calc_pure_string(str1) == 7)

	def test_add_neg(self):
		expr1 = Expr('+', [Expr(-2) , Expr(3)])
		self.assertTrue(expr1.evaluate() == 1)

	def test_string_add_neg(self):
		str1 = "['+', 1, -2]"
		expr1 = string_to_expr(str1)
		self.assertTrue(calc(expr1) == -1)

if __name__ == '__main__':
    unittest.main()