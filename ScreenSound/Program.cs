using ScreenSound.Menus;
using OpenAI_API;

// Dura 3 meses
var client = new OpenAIAPI("hashapi");

var chat = client.Chat.CreateConversation();

chat.AppendSystemMessage("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal");

string resposta = await chat.GetResponseFromChatbotAsync();
Console.WriteLine(resposta);