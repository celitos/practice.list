value = int(input('Type product value: '))

while value > 20:
  value = (value * 0,10) + value
  print(f'The final value of your product will    be US$ {value}')
  break
