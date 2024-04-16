// DESAFIO ANIMAIS
// Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe.
// Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

using ScreenSound.Desafios.Animais;

Animal animal1 = new Peixe();
animal1.EmitirSom();
Animal animal2 = new Ave();
animal2.EmitirSom();
Animal animal3 = new Mamifero();
animal3.EmitirSom();