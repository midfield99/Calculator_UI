import numbers

def add(args):
	return args[0].evaluate() + args[1].evaluate()

def sub(args):
	return args[0].evaluate() - args[1].evaluate()

def multiply(args):
	return args[0].evaluate() * args[1].evaluate()

def div(args):
	return args[0].evaluate() / args[1].evaluate()

def test(exp):
	if exp.args[0].valid():
		if exp.args[1].valid():
			return "Valid"
		else:
			return "Invalid arguement 2:" + repr(exp.args[1])
	else:
		return "Invalid arguement 1:" + repr(exp.args[0])

class Expr(object):
	def __repr__(self):
		if self.args:
			return 'Expr(start_symbol=%s, arguements=%s)' % (str(self.start), repr(self.args))
		else:
			return 'Expr(start_symbol=%s)' % str(self.start)

	def __init__(self, start_symbol, arguements = None):
		self.operations = {'+' : add, '-' : sub,'*' : multiply, '/' : div}
		self.validate = {'+' : test, '-' : test,'*' : test, '/' : test}
		self.start = start_symbol

		if arguements == None:
			self.args = []
		else:
			self.args = arguements

	def add_args(self, arg):
		self.args.append(arg)

	#I don't want to try to evaluate invalid strings.
	# and I don't need to evaluate a symbol to check for validity.
	# so I should just call valid() for every symbol.
	def valid(self):
		#if start symbol has a list of arguements it is an operation
		if self.args:
			#each operation can have it's own rules for validity.
			if self.operations.get(self.start, None) != None:
				self.error = str(self.validate[self.start](self))
				#operation symbols need to be in operations.
				if self.error == "Valid":
					return True
				else:
					return False
			else:
				self.error = "Invalid Operation:" + repr(self.start)
				return False
		#otherwise it needs to be a real number
		else:
			if isinstance(self.start, numbers.Real):
				self.error = "Valid"
				return True
			else:
				self.error = str(self.start) + " with no arguements is invalid."
				return False


	def evaluate(self):
		self.valid()
		if self.error == "Valid":
			#list is empty, so if it is valid, it is a number.
			if not self.args:
				return float(self.start)
			else:
				return self.operations[self.start](self.args)
		else:
			return self.error


def calc(eval_expr):
	if eval_expr.valid():
		try:
			return eval_expr.evaluate()
		#I don't want to evaluate to test for validity so,
		# there are some cases where the grammar should be declared valid,
		# but it will raise an error (eg divide by 0.) Those should still be caught.
		except ZeroDivisionError:
			return "Cannot divide by zero." 
	else:
		return eval_expr.error