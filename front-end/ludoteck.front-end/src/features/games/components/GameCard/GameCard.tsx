import { Game } from '../../models/Game';

interface GameCardProps {
  game: Game;
}

export const GameCard = ({ game }: GameCardProps) => {
  return (
    <article className="flex-shrink-0 w-full md:w-[400px] border border-gray-200 bg-white rounded-xl shadow-[0_3px_10px_rgb(0,0,0,0.2)] hover:shadow-[0_8px_30px_rgb(0,0,0,0.12)] hover:border-gray-300 transition-all duration-300 ease-in-out hover:-translate-y-1">
      <div className="p-6">
        <h2 className="text-2xl font-bold text-gray-800 mb-2 line-clamp-2">{game.titre}</h2>
        <div className="inline-block px-3 py-1 mb-4 text-sm font-semibold text-indigo-600 bg-indigo-100 rounded-full">
          {game.annee}
        </div>
        <p className="text-gray-600 leading-relaxed line-clamp-3">
          {game.description}
        </p>
      </div>
    </article>
  );
};

export default GameCard; 