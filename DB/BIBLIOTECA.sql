CREATE SCHEMA `biblioteca` DEFAULT CHARACTER SET utf8;

USE biblioteca;

CREATE TABLE IF NOT EXISTS LIVROS (
  ID INT NOT NULL UNIQUE AUTO_INCREMENT,
  TITULO VARCHAR(255) NOT NULL,
  AUTOR VARCHAR(255) NOT NULL,
  ISBN VARCHAR(13),
  CONSTRAINT PK_LIVROS PRIMARY KEY(ID)
);

INSERT INTO
  LIVROS (TITULO, AUTOR, ISBN)
VALUES
  ('Crepúsculo dos Ídolos', 'Friedrich Nietzsche', 9781982653859),
  ('Minimanual do Guerrilheiro Urbano', 'Carlos Marighella', 9781934941300),
  ('Darwin Sem Frescura', 'Reinaldo Jose Lopes E Pirula', 9788595084698),
  ('As Origens do Totalitarismo', 'Hannah Arendt', 9780241316757),
  ('Ética', 'Baruch Espinoza', 9781452604657);

SELECT * FROM LIVROS;