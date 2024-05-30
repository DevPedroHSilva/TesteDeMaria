using System;
using System.Collections.Generic;

/// <summary>
/// Classe criada para simular a funcionalidade do asp.net, ela usa os padrões singleton para assegurar
/// que somente uma instancia da sessão permaneça mantida na aplicação.
/// Criei ela para evitar de ficar passando muitos parametros entre os formularios, ao inves disso 
/// passo apenas para ela e assim o código não fica tão extenso.
/// </summary>
public class Session
{
    private static Session _instance;
    private Dictionary<string, object> _sessionDictionary;

    private Session()
    {
        _sessionDictionary = new Dictionary<string, object>();
    }

    public static Session Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Session();
            }
            return _instance;
        }
    }

    // Indexador para acessar os dados da sessão
    public object this[string key]
    {
        get
        {
            _sessionDictionary.TryGetValue(key, out var value);
            return value;
        }
        set
        {
            _sessionDictionary[key] = value;
        }
    }

    // Método para remover um item da sessão
    public void Remove(string key)
    {
        if (_sessionDictionary.ContainsKey(key))
        {
            _sessionDictionary.Remove(key);
        }
    }

    // Método para limpar a sessão
    public void Clear()
    {
        _sessionDictionary.Clear();
    }
}
