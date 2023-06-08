import math

area = None
Raio = None

def read_numeric():
  try:
    # read for Python 2.x
    return float(raw_input())
  except NameError:
    # read for Python 3.x
    return float(input())


Raio = read_numeric()

area = str("{:0.4f}".format((3.14159 * (math.pow(Raio, 2)))))

print ("A=" + area)
