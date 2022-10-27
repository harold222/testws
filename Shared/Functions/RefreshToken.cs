﻿using WSGYG63.Models.Token;

namespace WSGYG63.Shared.Functions
{
    public class RefreshToken
    {
        public async Task<GlobalToken> verify(string urlHost, TokenParams tokenParams, string urlToken = "", string token = "", DateTime? expired = null, Dictionary<string, string> dataToGetToken = null)
        {
            GlobalToken currentToken = null;
            Http http = new();

            try
            {
                if (!string.IsNullOrEmpty(token))
                {
                    bool expiredToken = new CheckDate().IsExpired(expired);

                    if (expiredToken)
                    {
                        // si el token - 1 minuto ya se expiro, genero uno nuevo
                        TokenResponse newToken = await http.GetToken<TokenResponse>(urlToken, tokenParams.client_id, dataToGetToken).ConfigureAwait(false);

                        if (newToken != null)
                        {
                            currentToken = new()
                            {
                                AccessToken = newToken.AccessToken,
                                DateExpire = refresh(newToken.ExpiresIn),
                                DataToGetToken = dataToGetToken,
                                UrlToken = urlToken
                            };
                        }
                    }
                    else
                        // si no hay problemas con el token actual, regreso la misma informacion
                        currentToken = new()
                        {
                            AccessToken = token,
                            UrlToken = urlToken,
                            DataToGetToken = dataToGetToken,
                            DateExpire = expired
                        };
                }
                else
                {
                    // si hubo un problema en el constructor del servicio, genero el token
                    Dictionary<string, string> data =
                                dataToGetToken == null ?
                                    new ModelToDictionary().Trasform<TokenParams>(tokenParams) :
                                    dataToGetToken;

                    string modUrl = string.IsNullOrEmpty(urlToken) ?
                        $"{urlHost}/OAuth_APIM/GenerateToken" :
                        urlToken;

                    TokenResponse newToken = await http.GetToken<TokenResponse>(modUrl, tokenParams.client_id, data).ConfigureAwait(false);

                    if (newToken != null)
                    {
                        currentToken = new()
                        {
                            UrlToken = modUrl,
                            AccessToken = newToken.AccessToken,
                            DataToGetToken = data,
                            DateExpire = refresh(newToken.ExpiresIn)
                        };
                    }
                }
            }
            catch (Exception e)
            {
                // escribir en log
            }

            return currentToken;
        }

        public DateTime? refresh(string expiresIn)
        {
            try
            {
                return DateTime.Now.AddSeconds(Convert.ToDouble(expiresIn));
            }
            catch (Exception e)
            {
                // log de conversion de fecha a expirar e.ToString();
            }

            return null;
        }
    }
}
