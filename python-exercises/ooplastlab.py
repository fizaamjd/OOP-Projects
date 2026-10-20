base = float(input("Tell the base "))
height = float(input("Tell the height "))
area = 0.5 * base * height
if(area > 100):
 print("Area is" , area)
else:
 print("Area is less")
i = int(input("Tell number"))
while(i != -1):
 i = int(input("Tell number"))
num = [0,0,0,0]
for i in range(0,3):
 num[i] = int(input("Enter number "))
largest = num[0]
for i in range(0,3):
 if(num[i] > largest):
  largest = num[i]
print("largest number is", largest)
def add(a,b):
 return a+ b
def main() :
 print(add(2,3))
if __name__ == "__main__":
 main()



