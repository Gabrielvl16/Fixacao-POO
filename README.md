# Sistema de Gerenciamento de Animais - POO 🐶🐱🐦

Este é um projeto simples de um sistema de gerenciamento de animais, implementado utilizando o conceito de Programação Orientada a Objetos (POO) em C#. O sistema permite adicionar diferentes tipos de animais ao zoológico 🦁, apresentar informações sobre os animais 🐾 e realizar exames veterinários 🩺.

## Funcionalidades 🌟

- **Adicionar Animais**: O sistema permite adicionar cães 🐕, gatos 🐈 e pássaros 🐦 ao zoológico.
- **Mostrar Animais**: Exibe informações sobre todos os animais registrados no zoológico.
- **Examinar Animal**: Um veterinário 🐾 pode examinar um animal e fazer ele emitir o som característico da sua espécie.
- **Entrada de Dados**: O sistema permite que o usuário insira o nome e a idade dos animais ao adicioná-los.

## Estrutura do Código 📂

### Classes e Funcionalidades

- **Animal (classe abstrata)**: Serve como base para as classes de animais. Possui propriedades como `Nome` e `Idade` e métodos como `EmitirSom()` (método abstrato que deve ser implementado pelas classes derivadas) e `Apresentar()` (método virtual que pode ser sobrescrito).
  
- **Cachorro, Gato e Passaro (classes derivadas)**: São classes concretas que herdam de `Animal` e implementam o método `EmitirSom()` de maneira específica para cada tipo de animal.

- **Zoo**: Representa o zoológico 🦒, onde os animais são armazenados e podem ser exibidos. Contém uma lista de objetos `Animal` e métodos para adicionar animais e mostrar os registros.

- **Veterinario**: Representa o veterinário 🩺, que pode examinar um animal e ouvir o som que ele faz.

- **Program**: A classe principal, onde a interação com o usuário acontece. Permite ao usuário adicionar animais, visualizar a lista de animais e realizar exames.

## Como Rodar o Projeto 🚀

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
