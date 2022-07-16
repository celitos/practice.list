sale_completed = False
sale_data = 'Sale completed: U$47.50'

for send in range(3):
  if sale_completed:
    print(sale_data)
    print('Additional Information sent to your email address')   
    break 
else:
  print('Sale not completed.')
#filetest
