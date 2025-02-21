# -.-AI--
# Опис коду

## Функція `addBinary`
Ця функція приймає два рядки, які представляють двійкові числа, і повертає їхню суму як рядок у двійковій формі.

### Алгоритм:
1. **Доповнення рядків до однакової довжини**:
   - Вирівнюються обидва рядки, додаючи нулі на початок (`padStart`).
2. **Ітерація з правого кінця**:
   - Підсумовуються біти обох рядків разом із переносом (`carry`).
   - Результат для кожного біта визначається як `bitSum % 2`, а новий перенос — як `Math.floor(bitSum / 2)`.
3. **Обробка залишкового переносу**:
   - Якщо після ітерації залишився перенос, він додається до результату.
4. **Формування результату**:
   - Масив `result` перевертається та об'єднується у рядок.

### Використання:
```typescript
console.log(addBinary("1010", "1011")); // Виведе "10101"
