class Solution:
    def addBinary(self, a, b):
        carry = 0
        result = []
        
        a = a.zfill(max(len(a), len(b)))
        b = b.zfill(max(len(a), len(b)))
        
        for i in range(len(a) - 1, -1, -1):
            bit_sum = carry
            bit_sum += 1 if a[i] == '1' else 0
            bit_sum += 1 if b[i] == '1' else 0
            
            result.append(str(bit_sum % 2))
            carry = bit_sum // 2
        
        if carry:
            result.append('1')
            
        return ''.join(result[::-1])
